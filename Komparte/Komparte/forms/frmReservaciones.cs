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

        private void filterObj() {
        
        }

        private void clearField() 
        {

        }

        private void save() 
        {
        
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
