using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Komparte.Class;
using Komparte.forms;
using WindowsFormsApp1;
using Presentation;

namespace Komparte.forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        /*
        private void Login()
        {//Iniciar sesión

            //Validar campos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese nombre de usuario o correo electrónico");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Ingrese contraseña");
                return;
            }
            //Fin Validar campos

            if (userModel != null)//Si el inicio de sesión fue exitosa.
            {


                Form mainForm;//Definir el campo para el formulario principal.

                if (Common.ActiveUser.Position == Positions.GeneralManager || ActiveUser.Position == Positions.Accountant
                    || Common.ActiveUser.Position == Positions.AdministrativeAssistant || ActiveUser.Position == Positions.SystemAdministrator)
                {
                    //Enviar el modelo de vista del usuario conectado, para mostrar sus datos en el formulario principal. 
                    mainForm = new frmMain(userModel);
                }
                else if (ActiveUser.Position == Positions.HMR)
                {
                    mainForm = new ChildForms.FormUsers();
                }
                else if (ActiveUser.Position == Positions.Receptionist)
                {
                    mainForm = new ChildForms.FormPacients();
                }
                else if (ActiveUser.Position == Positions.MarketingGuru)
                {
                    mainForm = new ChildForms.FormReports();
                }
                else
                {
                    mainForm = null;
                    MessageBox.Show("Usted no tiene un cargo asignado, no puede iniciar sesión.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Hide();//Ocultar el formualario login.
                var welcomeForm = new WelcomeForm(userModel.FullName);//Mostrar el formulario de bienvenida.
                welcomeForm.ShowDialog();
                mainForm.FormClosed += new FormClosedEventHandler(MainForm_SessionClosed);//Asociar el evento cerrado, para limpiar el formulario login cuando se cierre sesion desde el formulario principal.
                mainForm.Show();//Mostrar el formulario principal.
            }
            else //Si el inicio de sesión NO fue exitosa, mostrar mensaje.
                ShowMessage("Usuario o contraseña incorrecto");

        }*/

        private void button4_Click(object sender, EventArgs e)
        {
            //Login();//Invocar el método Iniciar sesión.
            this.Hide();//Ocultar el formualario login.
            var frmCarga = new frmCarga("Welcome");//Mostrar el formulario de bienvenida.
            frmCarga.ShowDialog();
            frmMain frm = new frmMain();
            frm.Show();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {
        }

        
        private void panel7_Move(object sender, EventArgs e)
        {
        }

        private void panel7_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
            else if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void textBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (txtClave.Text == "CLAVE")
            {
                txtClave.Text = "";
            }
            else if (txtClave.Text == "")
            {
                txtClave.Text = "CLAVE";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmQR frm = new frmQR();
            frm.Show();
            this.Hide();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
