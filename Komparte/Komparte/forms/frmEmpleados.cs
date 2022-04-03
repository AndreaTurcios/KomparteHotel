using Domain;
using Presentation.Helpers;
using Presentation.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Komparte.forms
{
    public partial class frmEmpleados : Form
    {
        private bool userModify; //Obtiene o establece un usuario será editado.
        private int userId;//Obtiene o establece el id del usuario a editar.
        private UserModel userModel = new UserModel();
        private List<UserModel> userList;
        public frmEmpleados()
        {
            InitializeComponent();
            //FillFields();   //LLenar los campos del formulario con el modelo de usuario (Ver metodo).                 
            ListUsers();
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

        private void ListUsers()
        {//LLenar la cuadricula de datos con la lista de usuarios.
            userList = userModel.GetAllUsers().ToList();//Obtener todos los usuarios.
            dataGridView1.DataSource = userList;//Establecer la fuente de datos.
        }


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
            ListUsers();
        }

        private void FillFields()
        {//Cargar los datos del modelo  en los campos del formulario.
            txtNombre.Text = userModel.FirstName;
            txtUser.Text = userModel.Username;
            txtPhone.Text = userModel.Phone;
            txtDUI.Text = userModel.DUI;
            txtClaveA.Text = userModel.Password;
            txtCorreo.Text = userModel.Email;
            txtDireccion.Text = userModel.Direction;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("No hay datos para seleccionar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dataGridView1.SelectedCells.Count > 1)
            {
                var result = userModel.RemoveUser((int)dataGridView1.CurrentRow.Cells[0].Value);//Obtener ID del usuario e invocar el metodo eliminar usuario del modelo.

                if (result > 0)
                {
                    MessageBox.Show("Usuario eliminado con éxito");
                    ListUsers();
                }
                else MessageBox.Show("No se ha realizado operación, intente nuevamente");
            }
            else
                MessageBox.Show("Por favor seleccione una fila", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    }

