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
    public partial class frmActEntorno : Form
    {
        public frmActEntorno()
        {
            InitializeComponent();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        /*
        private void FillUserModel()
        {//LLenar modelo
            userModel.FirstName = txtNombre.Text;
            userModel.Username = txtUser.Text;
            userModel.Phone = txtPhone.Text;
            userModel.DUI = txtDUI.Text;
            userModel.Password = txtClaveA.Text;
            userModel.Email = txtCorreo.Text;
            userModel.Direction = txtDireccion.Text;
        }


        private void Save()
        {//Guardar cambios.
            int result = -1;
            try
            {
                FillUserModel();//Obtener modelo de vista.
                var validateData = new DataValidation(userModel);//Validar campos del objeto.
                var validatePassword = txtClaveA.Text == txtConfirmPass.Text;//Validar contraseñas.

                if (validateData.Result == true && validatePassword == true)//Si el objeto y contraseña es válido.
                {
                    //EDITAR USUARIO
                    if (userModify == true)
                    {
                        result = userModel.ModifyUser();//Invocar metodo ModifyUser del modelo de usuario.
                        if (result > 0)
                        {
                            MessageBox.Show("Usuario actualizado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = System.Windows.Forms.DialogResult.OK;//Establecer Ok como resultado de dialogo del formulario.
                            this.Close();//Cerrar formulario
                        }
                        else
                        {
                            MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    //AGREGAR USUARIO
                    else
                    {
                        result = userModel.CreateUser(); //Invocar metodo CreateUser del modelo de usuario.

                        if (result > 0)
                        {
                            MessageBox.Show("Usuario agregado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = System.Windows.Forms.DialogResult.OK; //Establecer Ok como resultado de dialogo del formulario.
                            this.Close();//Cerrar formulario
                        }
                        else
                        {
                            MessageBox.Show("No se realizó la operación, intente nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else //Si el objeto o contraseña NO es válido, mostrar mensaje segun el caso.
                {
                    if (validateData.Result == false)
                        MessageBox.Show(validateData.ErrorMessage, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                        MessageBox.Show("Las contraseñas no coinciden", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                var message = ExceptionManager.GetMessage(ex);//Obtener mensaje de excepción.
                MessageBox.Show(message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);//Mostrar mensaje.
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();
        }*/
    }
}
