using Domain;
using Presentation.Helpers;
using Presentation.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Komparte.classes.model;
using Komparte.classes.dao;
using System.Diagnostics;

namespace Komparte.forms
{
    public partial class frmEmpleados : Form
    {
        private bool userModify; //Obtiene o establece un usuario será editado.
        private int userId;//Obtiene o establece el id del usuario a editar.
        private UserModel userModel = new UserModel();
        private EstadoEmpleadoModel estadoEmpleadoModel = new EstadoEmpleadoModel();
        private EstadoEmpleadoDao estadoEmpleadoDao = new EstadoEmpleadoDao();
        private TipoEmpleadoDao tipoEmpleadDao = new TipoEmpleadoDao();
        private List<UserModel> userList;
        public frmEmpleados()
        {
            InitializeComponent();
            //FillFields();   //LLenar los campos del formulario con el modelo de usuario (Ver metodo).                 
            ListUsers();
            txtClaveA.UseSystemPasswordChar = false;//Quitar el enmascaramiento de caracteres.
            txtConfirmPass.UseSystemPasswordChar = false;
            //Combota tu lista de eSTADO
            List<classes.entidades.EstadoEmpleado> listClaseEmpleados = new List<classes.entidades.EstadoEmpleado>();
            listClaseEmpleados = (List<classes.entidades.EstadoEmpleado>)estadoEmpleadoDao.GetAllEstadoEmpleados();

            List<classes.entidades.TipoEmpleado> listTipoEmleado = new List<classes.entidades.TipoEmpleado>();
            listTipoEmleado = (List<classes.entidades.TipoEmpleado>)tipoEmpleadDao.GetAllTipoEmpleado();
            Debug.WriteLine("Buenasssssssssssssssssssss") ;

            Debug.WriteLine(listClaseEmpleados);
            /* List <classes.EstadoEmpleado> listClaseEmpleados = new List<classes.EstadoEmpleado>();
              listClaseEmpleados.Clear();
              classes.EstadoEmpleado estado1 = new classes.EstadoEmpleado(1,"E1");
              classes.EstadoEmpleado estado2 = new classes.EstadoEmpleado(2, "E2");
              listClaseEmpleados.Add(estado1);
              listClaseEmpleados.Add(estado2);
              Console.WriteLine(listClaseEmpleados);
            //  this.comboBox1 = new ComboBox();
              foreach (classes.EstadoEmpleado item in listClaseEmpleados) {
                  this.comboBox1.Items.Add(item);
                  this.comboBox2.Items.Add(item);
              }
            */
            //this.comboBox1.DataSource = listClaseEmpleados;
            foreach (classes.entidades.EstadoEmpleado item in listClaseEmpleados)
            {
                this.comboBox1.Items.Add(item);
            }

            foreach (classes.entidades.TipoEmpleado item2 in listTipoEmleado)
            {
                this.comboBox2.Items.Add(item2);
            }

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
            if (txtClaveA.PasswordChar == '*' || txtConfirmPass.PasswordChar == '*')
            {
                button6.Text="Ocultar";
                txtClaveA.PasswordChar = '\0';
                txtConfirmPass.PasswordChar = '\0';
            }
            else
            {
                button6.Text = "Mostrar";
                txtClaveA.PasswordChar = '*';
                txtConfirmPass.PasswordChar = '*';
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

            if (this.comboBox1.SelectedItem != null)
            {
                //Debug.WriteLine("Estado Empleado " + this.comboBox1.SelectedItem.ToString());
                //Debug.WriteLine("Objeto  " + this.comboBox1.SelectedItem.GetType());
                //Debug.WriteLine(this.comboBox1.SelectedValue);
                classes.entidades.EstadoEmpleado temp = (classes.entidades.EstadoEmpleado) this.comboBox1.SelectedItem;
                userModel.Estado = temp.idEstadoEmpleado;
                Debug.WriteLine("idestadoempleado " + userModel.Estado);
                Debug.WriteLine("idestadoempleado " + temp.idEstadoEmpleado);
            }

            if (this.comboBox2.SelectedItem != null)
            {
                //Debug.WriteLine("Estado Empleado " + this.comboBox1.SelectedItem.ToString());
                //Debug.WriteLine("Objeto  " + this.comboBox1.SelectedItem.GetType());
                //Debug.WriteLine(this.comboBox1.SelectedValue);
                classes.entidades.TipoEmpleado temp2 = (classes.entidades.TipoEmpleado) this.comboBox2.SelectedItem;
                userModel.TipoEmpleado = temp2.idTipoEmpleado;
                Debug.WriteLine("idtipoempleado " + userModel.Estado);
                Debug.WriteLine("idtipoempleado " + temp2.idTipoEmpleado);
            }
            userModel.IdHotel = 1;

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


            /*
             Varialbes a mandar  para el create
            txtNombre                   ->DB    nombre_empleado varchar(30)
            txtUser                     ->DB    nombre_usuario  varchar(35)
            txtCorreo                   ->DB    correo varchar(50)
            txtPhone                    ->DB    telefono varchar(30)
            txtDUI                      ->DB    DUI_empleado varchar(30)
            txtClaveA // txtConfirmPass ->DB    constrasenia_usuario varchar(35)
            txtDireccion                ->DB    direccion varchar(30)
            Estado empleado ->comboBox1 ->DB    pk_estado_empleado FK int    
            Tipo empleado -> comboBox2  ->DB    pk_tipo_empleado FK int
            txtIdHotel                  ->DB    pk_hotel_empleado(FK,int,not null)
             */
            Debug.WriteLine("Elementos a enviar");
           

            Debug.WriteLine("Nombre " + this.txtNombre.Text);
            Debug.WriteLine("Usuario " + this.txtUser.Text);
            Debug.WriteLine("Correo " + this.txtCorreo.Text);
            Debug.WriteLine("Telefono " + this.txtPhone.Text);
            Debug.WriteLine("DUI " + this.txtDUI.Text);
            Debug.WriteLine("Contrasenya " + this.txtClaveA.Text);
            Debug.WriteLine("Direccion " + this.txtDireccion.Text);
            if (this.comboBox1.SelectedItem != null)
            {
                Debug.WriteLine("Estado Empleado " + this.comboBox1.SelectedItem.ToString());
                Debug.WriteLine("Objeto  " + this.comboBox1.SelectedItem.GetType());
                //Debug.WriteLine(this.comboBox1.SelectedValue);
            }

            if (this.comboBox2.SelectedItem != null)
            {
                Debug.WriteLine("Tipo Empleado " + this.comboBox2.SelectedItem.ToString());
                Debug.WriteLine("Objeto " + this.comboBox2.SelectedItem.GetType());
                //Debug.WriteLine(this.comboBox2.SelectedValue);
            }
            Debug.WriteLine("Hotel " + this.txtIdHotel.Text);


            Save();
            // ListUsers();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FillFields();
        }
    }
    }

