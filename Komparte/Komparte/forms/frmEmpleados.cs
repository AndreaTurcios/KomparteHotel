﻿using System;
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
            if (cbClave.Checked == true)
            {
                if (txtClave.PasswordChar == '*')
                {
                    txtClave.PasswordChar = '\0';
                }
            }
            else
            {
                txtClave.PasswordChar = '*';
            }
        }
    }
}
