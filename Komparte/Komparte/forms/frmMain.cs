using Komparte.forms;
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
using Komparte.forms.obj;
using Komparte.forms;
using Domain;

namespace Komparte
{
    public partial class frmMain : Form
    {
        private List<Form> listChildForms; //Obtiene o establece los formularios secundarios abiertos en el panel escritorio del formualario.
        private Form activeChildForm;//Obtiene o establece el formulario secundario mostrado actualmente.
        public frmMain()
        {
            InitializeComponent();
            hideSubMenu();
            panelBotones.Visible = false;
            panelBotones2.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            btnChildFormClose.Visible = false;
            lblCaption.Visible = false;
            listChildForms = new List<Form>();
        }
        private const int cGrip = 30;      // Grip size
        private const int cCaption = 610;   // Caption bar height;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public frmMain(UserModel userModel)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            listChildForms = new List<Form>();
            LoadUserData(userModel);
        }
        public void LoadUserData(Domain.UserModel userModel)
        {
            //Cargar los datos del usuario conectado en el menú lateral.
            lblName.Text = userModel.Username;
            lblUserr.Text = userModel.Username;
            lblLastName.Text = userModel.Email;
            lblPosition.Text = userModel.Position;
        }
        /*
        public frmMain(UserModel userModel)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            listChildForms = new List<Form>();
            LoadUserData(userModel);
        }*/
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            panelBotones.Visible = false;
            panelBotones2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBotones);
        }

        private void btnClose_Click(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        protected void CloseApp()
        {
            if (MessageBox.Show("¿Está seguro de cerrar Komparte?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();//Cierra toda la aplicación finalizando todos los procesos.
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.CloseApp();//Cierra la aplicación.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmReservaciones>(sender);//Si el control es un boton del menu lateral enviar el objeto remitente
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBotones2);
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnTipoEntorno_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmEntorno>(sender);//Si el control es un boton del menu lateral enviar el objeto remitente
        }
        private void ActivateButton(Button menuButton)
        {
            menuButton.ForeColor = Color.FromArgb(0, 100, 182);
            //menuButton.BackColor = panelMenuHeader.BackColor;
        }
        private void DeactivateButton(Button menuButton)
        {
            menuButton.ForeColor = Color.DarkGray;
            //menuButton.BackColor = panelSideMenu.BackColor;
        }

        private void CleanDesktop()
        {//Limpiar el escritorio.

            if (activeChildForm != null)
            {
                activeChildForm.Hide();
                panelDesktop.Controls.Remove(activeChildForm);
            }
        }

        private void OpenChildForm<ChildForm>(object senderMenuButton) where ChildForm : Form, new()
        {
            Button menuButton = (Button)senderMenuButton;//Boton de donde se abre el formulario, puedes enviar un valor nulo, si no estas tratando de abrir un formulario desde un control diferente de los botones del menu lateral.
            Form form = listChildForms.OfType<ChildForm>().FirstOrDefault();//Buscar si el formulario ya está instanciado o se ha mostrado anteriormente.

            if (activeChildForm != null && form == activeChildForm)//Si el formulario es igual al formulario  actual activo, retornar ( no hacer nada).
                return;

            if (form == null)//Si el formulario no existe, entonces crear la instancia y mostrarla en el panel escritorio.
            {

                form = new ChildForm();// Instanciar formulario.   
                form.FormBorderStyle = FormBorderStyle.None;//Quitar el borde.
                form.TopLevel = false;//Indicar que el formulario no es de nivel superior  
                form.Dock = DockStyle.Fill; //Establecer el estilo de muelle en lleno (Rellenar el panel escritorio)          
                listChildForms.Add(form);//Agregar formulario secundario a la lista de formularios.

                if (menuButton != null)//Si el boton de menu es diferente a nulo:
                {
                    ActivateButton(menuButton);//Activar/Resaltar el boton.
                    form.FormClosed += (s, e) =>
                    {//Cuando del formulario se cierre, desactivar el boton.
                        DeactivateButton(menuButton);
                    };
                }
                btnChildFormClose.Visible = true;//Mostrar el boton de cerrar formulario secundario.
            }
            CleanDesktop();//Eliminar el formulario secundario actual del panel escritorio
            panelDesktop.Controls.Add(form);//agregar formulario secundario al panel del escritorio
            panelDesktop.Tag = form;// Almacenar el formulario
            form.Show();//Mostrar el formulario 
            form.BringToFront();// Traer al frente
            form.Focus();//Enfocar el formulario
            lblCaption.Visible = true;
            lblCaption.Text = form.Text;//Establecer el titulo del formulario.
            activeChildForm = form;//Establecer como formulario activo.
        }
        private void ResetDefaults()
        {
            activeChildForm = null;
            lblCaption.Text = "   Home";
            btnChildFormClose.Visible = false;
        }
        private void RefreshDesktop()
        {//Este método es responsable  de actualizar el formulario principal con los parametros adecuados,
            //ya sea restablecer los valores pretederminados o mostrar un formulario secundario anterior si es el caso.
            var childForm = listChildForms.LastOrDefault();//Verificar y obtener el último formulario secundario (anterior) en la lista de formularios
            if (childForm != null)//si hay un formulario secundario instanciado en la lista, agregarlo de nuevo al panel escritorio.
            {
                activeChildForm = childForm;
                panelDesktop.Controls.Add(childForm);
                panelDesktop.Tag = childForm;
                childForm.Show();
                childForm.BringToFront();
                lblCaption.Text = childForm.Text;
            }
            else //Si no hay ningún resultado, no hay ninguna instancia en la lista de formularios secundarios.
            {
                ResetDefaults();//Restablecer el formulario principal a los valores predeterminados
            }
        }
        private void CloseChildForm()
        {//Cerrar formulario secundario activo.

            if (activeChildForm != null)
            {
                listChildForms.Remove(activeChildForm);//Eliminar de la lista de formularios.
                panelDesktop.Controls.Remove(activeChildForm);//Eliminar del panel escritorio.
                activeChildForm.Close();//Cerrar el formulario.
                RefreshDesktop();//Actualizar el escritorio (Mostrar el formulario anterior si es el caso, caso contrario restablecer el formulario principal)
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmClientes>(sender);//Si el control es un boton del menu lateral enviar el objeto remitente
        }

        private void btnChildFormClose_Click(object sender, EventArgs e)
        {
            CloseChildForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmEmpleados>(sender);//Si el control es un boton del menu lateral enviar el objeto remitente
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBoxPhoto_Click(object sender, EventArgs e)
        {

        }

        private void btnTipoActividades_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmActEntorno>(sender);//Si el control es un boton del menu lateral enviar el objeto remitente
        }

        private void btnTipoHotel_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmTipoHotel>(sender);//Si el control es un boton del menu lateral enviar el objeto remitente
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm<frmFactura>(sender);//Si el control es un boton del menu lateral enviar el objeto remitente
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmPais>(sender);//Si el control es un boton del menu lateral enviar el objeto remitente
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmDepartamento>(sender);//Si el control es un boton del menu lateral enviar el objeto remitente
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmObjetivo>(sender);//Si el control es un boton del menu lateral enviar el objeto remitente
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmHoteles>(sender);//Si el control es un boton del menu lateral enviar el objeto remitente
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmEstadoCliente>(sender);//Si el control es un boton del menu lateral enviar el objeto remitente
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmEstadoReservacion>(sender);//Si el control es un boton del menu lateral enviar el objeto remitente
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmDepartamento>(sender);//Si el control es un boton del menu lateral enviar el objeto remitente
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmEventos>(sender);//Si el control es un boton del menu lateral enviar el objeto remitente
        }
    }
}