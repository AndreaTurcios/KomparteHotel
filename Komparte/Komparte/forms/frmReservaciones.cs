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

namespace Komparte.forms.obj
{
    public partial class frmReservaciones : Form
    {
        private bool reservacionModify = false;
        private string reservacionId;
        ReservacionModel reservacionModel = new ReservacionModel();
        EstadoClienteModel estadoClienteModel = new EstadoClienteModel();
        ClienteModel clienteModel = new ClienteModel();
        ServicioModel servicioModel = new ServicioModel();
        ReservacionFilter reservacionFilter = new ReservacionFilter(); 

        public frmReservaciones()
        {
            InitializeComponent();
            listOjb();
            foreach (EstadoCliente item in estadoClienteModel.get_all_estados_cliente())
            {
                this.comboBoxEstado.Items.Add(item);
            }

            foreach (Cliente item in clienteModel.get_all_cliente())
            {
                this.comboBoxCliente.Items.Add(item);
            }

            foreach (Servicio item in servicioModel.get_all_servicios())
            {
                this.comboBoxServicio.Items.Add(item);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listOjb() 
        {
            ReservacionModel reservacionModel_ = new ReservacionModel();
            dataGridReservacion.DataSource = reservacionModel_.f_all_reservacion();
        }

        private void filterObj() 
        {

            reservacionFilter.acompaniante = textAcompa.Text;
            reservacionFilter.numero_noches =  Int32.Parse(textHoras.Text);

            if (checkBoxDia.Checked == true)
            {
                reservacionFilter.checkin = "Si";
            }
            else
            {
                reservacionFilter.checkin = "No";
            }

            if (checkBoxNoche.Checked == true)
            {
                reservacionFilter.checkout = "Si";
            }
            else
            {
                reservacionFilter.checkout = "No";
            }

            if (this.comboBoxCliente.SelectedItem != null)
            {
                Cliente temp = (Cliente)this.comboBoxCliente.SelectedItem;
                reservacionFilter.pk_cliente = temp.id;
            }

            if (this.comboBoxEstado.SelectedItem != null)
            {
                EstadoCliente temp1 = (EstadoCliente)this.comboBoxEstado.SelectedItem;
                reservacionFilter.pk_estado_reservacion = temp1.id;
            }

            if (this.comboBoxServicio.SelectedItem != null)
            {
                Servicio temp2 = (Servicio)this.comboBoxServicio.SelectedItem;
                reservacionFilter.pk_servicio_reservacion = temp2.id;
            }

        }

        private void clearField() 
        {
            textAcompa.Text = "";
            textHoras.Text = "";
            checkBoxDia.Checked = false;
            checkBoxNoche.Checked = false;
            this.comboBoxCliente.SelectedItem = null;
            this.comboBoxEstado.SelectedItem = null;
            this.comboBoxServicio.SelectedItem = null;
            reservacionModify = false;
            reservacionId= null;
    }

        private void save() 
        {
            int result = -1;
            try
            {
                filterObj();
                var validateData = new DataValidation(reservacionFilter);
                if (validateData.Result == true)
                {
                    //Modificar 
                    if (reservacionModify == true)
                    {
                        //Modificar Estado
                        result = reservacionModel.f_update_reservacion(reservacionFilter.reservacion(reservacionId));
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
                        result = reservacionModel.f_create_reservacion(reservacionFilter.reservacion());
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
            if (dataGridReservacion.SelectedRows.Count == 1)
            {
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
            listOjb();
        }
    }
}
