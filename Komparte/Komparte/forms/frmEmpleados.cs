using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komparte.forms
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
            txtClaveA.UseSystemPasswordChar = false;//Quitar el enmascaramiento de caracteres.
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void cbClave_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClaveA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (txtClaveA.PasswordChar == '*')
            {
                txtClaveA.PasswordChar = '\0';
            }
            else
            {
                txtClaveA.PasswordChar = '*';
            }
        }
    }
}
