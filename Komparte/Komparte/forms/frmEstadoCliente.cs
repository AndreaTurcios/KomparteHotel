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
using Komparte.classes.filter;
using Komparte.classes.entidades;
using Presentation.Helpers;
using Presentation.Utils;
using System.Diagnostics;

namespace Komparte.forms
{
    public partial class frmEstadoCliente : Form
    {
        private bool estadoModify = false;
        private string estadoId;
        private EstadoClienteModel estadoClienteModel = new EstadoClienteModel();
        private EstadoClienteFilter estadoClienteFilter = new EstadoClienteFilter();

        public frmEstadoCliente()
        {
            InitializeComponent();
            listEstados();
        }

        public void listEstados()
        {
            EstadoClienteModel estadoModel_ = new EstadoClienteModel();
            dataTableEstado.DataSource = estadoModel_.f_all_estados();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            save();
            listEstados();
        }

        private void save()
        {
            int result = -1;
            try
            {
                filterEstado();
                var validateData = new DataValidation(estadoClienteFilter);
                if (validateData.Result == true)
                {
                    //Modificar 
                    if (estadoModify == true)
                    {
                        //Modificar Estado
                        result = estadoClienteModel.f_update_estado(estadoClienteFilter.estadoCliente(estadoId));
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
                        result = estadoClienteModel.f_create_estado(estadoClienteFilter.estadoCliente());
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

        private void filterEstado()
        {
            estadoClienteFilter.estado = txtEstado.Text;
        }

        private void clearField()
        {
            txtEstado.Text = "";
            estadoModify = false;
            estadoId = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectRow();
        }

        public void selectRow()
        {
            if (dataTableEstado.SelectedRows.Count > 0)
            {
                string srt = dataTableEstado.CurrentRow.Cells["ID_estado_cliente"].Value.ToString();
                Debug.WriteLine("idestado " + srt);
                string estadoTable = dataTableEstado.CurrentRow.Cells["estado"].Value.ToString();
                estadoModify = true;
                estadoId = srt;
                estadoClienteFilter.estado = estadoTable;
                txtEstado.Text = estadoClienteFilter.estado;

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataTableEstado.RowCount <= 0)
            {
                MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataTableEstado.SelectedCells.Count > 1)
            {
                //var result = userModel.RemoveUser((int)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario e invocar el metodo eliminar usuario del modelo.
                var result = estadoClienteModel.f_delete_estado(estadoClienteFilter.estadoCliente(dataTableEstado.CurrentRow.Cells[0].Value.ToString()));
                //userModel.RemoveUser((int)dataGridView1.CurrentRow.Cells[0].Value);

                if (result > 0)
                {
                    MessageBox.Show("Eliminado con éxito");
                    listEstados();
                }
                else MessageBox.Show("No se ha realizado operación, intente nuevamente");
            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
