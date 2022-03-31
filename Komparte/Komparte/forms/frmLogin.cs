using System;
using System.Drawing;
using Common;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsFormsApp1;
using Presentation;
using Domain;

namespace Komparte.forms
{
    public partial class frmLogin : Form
    {
        private string usernamePlaceholder;//Marca de agua(Placeholder) para el cuadro de texto usuario.
        private string passwordPlaceholder;//Marca de agua(Placeholder) para el cuadro de texto contraseña.
        private Color placeholderColor;//Color del marca de agua(Placeholder).
        private Color textColor;//Color para el texto del cuadro texto.

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

        private void ShowMessage(string message)
        {
            lblErrorMessage.Text = "    " + message;
            lblErrorMessage.Visible = true;
        }

        private void SetPlaceholder()
        {//Establecer la marca de agua (Placeholder) al cuadro de texto usuario y contraseña,
            //Siempre en cuando el valor sea nulo o tiene espacios en blanco.
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))//Usuario
            {
                txtUsuario.Text = usernamePlaceholder;
                txtUsuario.ForeColor = placeholderColor;
            }
            if (string.IsNullOrWhiteSpace(txtClave.Text))//Contraseña
            {
                txtClave.Text = passwordPlaceholder;
                txtClave.ForeColor = placeholderColor;
                txtClave.UseSystemPasswordChar = false;//Quitar el enmascaramiento de caracteres.
            }
        }

        private void Logout()
        {//Limpiar campos cuando se cierre sesión, este metodo se invoca en el metodo de evento MainForm_SessionClosed(..).
            this.Show();//Volver a mostrar el formulario login.
            txtUsuario.Clear();
            txtClave.Clear();
            SetPlaceholder();
            lblErrorMessage.Visible = false;
        }

        private void MainForm_SessionClosed(object sender, FormClosedEventArgs e)
        {
            Logout();////Invocar el método Cerrar sesión, cuando en el formulario principal se haya cerrado sesión.
        }

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

            var UserModel = new UserModel().Login(txtUsuario.Text, txtClave.Text);//Devuelve un objeto UserModel como resultado.
            if (UserModel != null)//Si el inicio de sesión fue exitosa.
            {
                Form mainForm;//Definir el campo para el formulario principal.

                if (Common.ActiveUser.Position == Positions.GeneralManager || ActiveUser.Position == Positions.Accountant
                    || Common.ActiveUser.Position == Positions.AdministrativeAssistant || ActiveUser.Position == Positions.SystemAdministrator)
                {
                    //Enviar el modelo de vista del usuario conectado, para mostrar sus datos en el formulario principal. 
                    mainForm = new frmMain(UserModel);
                }
                else if (ActiveUser.Position == Positions.HMR)
                {
                    mainForm = new forms.frmClientes();
                }
                else if (ActiveUser.Position == Positions.Receptionist)
                {
                    mainForm = new forms.frmFactura();
                }
                else if (ActiveUser.Position == Positions.MarketingGuru)
                {
                    mainForm = new forms.frmHoteles();
                }
                else
                {
                    mainForm = null;
                    MessageBox.Show("Usted no tiene un cargo asignado, no puede iniciar sesión.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Hide();//Ocultar el formualario login.
                var frmCarga = new frmCarga(UserModel.FullName);//Mostrar el formulario de bienvenida.
                frmCarga.ShowDialog();
                mainForm.FormClosed += new FormClosedEventHandler(MainForm_SessionClosed);//Asociar el evento cerrado, para limpiar el formulario login cuando se cierre sesion desde el formulario principal.
                mainForm.Show();//Mostrar el formulario principal.
            }
            else //Si el inicio de sesión NO fue exitosa, mostrar mensaje.
                MessageBox.Show("Inicio de sesion erroneo");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Login();//Invocar el método Iniciar sesión.
            this.Hide();//Ocultar el formualario login.
            var frmCarga = new frmCarga("Bienvenid@");//Mostrar el formulario de bienvenida.
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
