using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Komparte.classes.model;
using Komparte.classes.entidades;
using Komparte.classes.filter;
using Presentation.Helpers;
using Presentation.Utils;
using System.Diagnostics;

namespace Komparte.forms
{
    public partial class frmClientes : Form
    {
        private bool clienteModify = false;
        private string clienteId;
        EstadoClienteModel estadoClienteModel = new EstadoClienteModel();
        ClienteFilter clienteFilter = new ClienteFilter();
        ClienteModel clienteModel = new ClienteModel();
        Cliente cli;
        public frmClientes()
        {
            InitializeComponent();
            listClientes();
            foreach (EstadoCliente item in estadoClienteModel.get_all_estados_cliente())
            {
                this.comboBoxEstado.Items.Add(item);
            }
        }

        public void listClientes()
        {
            ClienteModel clienteModel_ = new ClienteModel();
            dataGridCliente.DataSource = clienteModel_.f_all_clientes();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save(); 
            listClientes();
        }

        private void filterCliente() 
        {
            clienteFilter.nombre = textNombre.Text;
            clienteFilter.dui = textDui.Text;
            clienteFilter.telefono = textTelefono.Text;
            clienteFilter.direccion = textDireccion.Text;
            clienteFilter.correo = textCorreo.Text;
            if (this.comboBoxEstado.SelectedItem != null)
            {
                EstadoCliente temp = (EstadoCliente)this.comboBoxEstado.SelectedItem;
                clienteFilter.pk_estado_cliente = temp.id;
            }
            clienteFilter.pk_hotel_cliente = 1;
        }

        private void clearField() {
            textNombre.Text = "";
            textDui.Text = "";
            textTelefono.Text = "";
            textDireccion.Text = "";
            textCorreo.Text = "";
            comboBoxEstado.SelectedItem = null;
            clienteModify = false;
            clienteId = null;
        }

        private void save() {
            int result = -1;
            try
            {
                filterCliente();
                var validateData = new DataValidation(clienteFilter);
                if (validateData.Result == true)
                {
                    //Modificar 
                    if (clienteModify == true)
                    {
                        //Modificar Estado
                        result = clienteModel.f_update_cliente(clienteFilter.cliente(clienteId));
                        if (result > 0)
                        {
                            MessageBox.Show("Estado actualizado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = System.Windows.Forms.DialogResult.OK;//Establecer Ok como resultado de dialogo del formulario.
                            clearField();
                            //this.Close();//Cerrar formulario
                        }
                        else
                        {
                            MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        //Agregar usuario 
                        //result = estadoClienteModel.f_create_estado(estadoClienteFilter.estadoCliente());
                        result = clienteModel.f_create_cliente(clienteFilter.cliente());
                        if (result > 0)
                        {
                            MessageBox.Show("Estado Agregado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = System.Windows.Forms.DialogResult.OK;//Establecer Ok como resultado de dialogo del formulario.
                            clearField();
                            //this.Close();//Cerrar formulario
                        }
                        else
                        {
                            MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(validateData.ErrorMessage, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                var message = ExceptionManager.GetMessage(ex);//Obtener mensaje de excepción.
                MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mostrar mensaje.
            }
        }

        public void selecRow()
        {
            if(dataGridCliente.SelectedRows.Count  ==1) 
            {
                string srt = dataGridCliente.CurrentRow.Cells["ID"].Value.ToString();
                cli = clienteModel.fClienteById(srt);
                textNombre.Text = cli.nombre;
                textDui.Text = cli.dui;
                textTelefono.Text = cli.telefono;
                textDireccion.Text = cli.direccion;
                textCorreo.Text = cli.correo;
                EstadoCliente temp = estadoClienteModel.getEstadoClienteById(cli.pk_estado_cliente);
                PosicionarCombo(this.comboBoxEstado,temp.estado);
                clienteModify = true;
                clienteId = srt;
            }
        }

        public void PosicionarCombo(ComboBox cmb, string valor)
        {
            int i = 0;
            foreach (object obj in cmb.Items)
            {
                if (obj.ToString() == valor)
                {
                    cmb.SelectedIndex = i;
                    break;
                }

                ++i;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selecRow();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridCliente.RowCount <= 0)
            {
                MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataGridCliente.SelectedCells.Count > 1)
            {
                //var result = userModel.RemoveUser((int)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario e invocar el metodo eliminar usuario del modelo.
                var result = clienteModel.f_delete_cliente((dataGridCliente.CurrentRow.Cells[0].Value.ToString()));
                //userModel.RemoveUser((int)dataGridView1.CurrentRow.Cells[0].Value);

                if (result > 0)
                {
                    MessageBox.Show("Eliminado con éxito");
                    listClientes();
                    clearField();
                }
                else MessageBox.Show("No se ha realizado operación, intente nuevamente");
            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
