using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DBServices;
using DataAccess.DBServices.Entities;
//using DataAccess.MailServices;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class UserModel
    {
        #region -> Atributos

        private int _id;
        private string _username;
        private string _password;
        private string _firstName;
        private string _DUI;
        private string _position;
        private string _email;
        private string _telefono;
        private string _direccion;
        private byte[] _photo;
        private UserDao _userDao;
        #endregion

        #region -> Constructores

        public UserModel()
        {
            _userDao = new UserDao();
        }

        public UserModel(int id, string userName, string firstName, string password,  string DUI, string telefono, string direccion, string email, string position)
        {
            Id = id;
            Direction = direccion;
            Username = userName;
            Password = password;
            FirstName = firstName;
            DUI = DUI;
            Phone = telefono;
            Position = position;
            Email = email;
            _userDao = new UserDao();
        }
        #endregion

        #region -> Propiedades + Validacíon y Visualización de Datos

        //Posición 0 
        [DisplayName("Num")]//Nombre a visualizar (Por ejemplo en la columna del datagridview se mostrará como Num).
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        //Posición 1 
        [DisplayName("Usuario")]//Nombre a visualizar.
        [Required(ErrorMessage = "El nombre de usuario es requerido.")]//Validaciones
        [StringLength(100, MinimumLength = 5, ErrorMessage = "El nombre de usuario debe contener un mínimo de 5 caracteres.")]
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        //Posición 2
        [DisplayName("Contraseña")]//Nombre a visualizar.
        [Browsable(false)]//Ocultar visualización (Por ejemplo no mostrar en el datagridview).
        [Required(ErrorMessage = "Por favor ingrese una contraseña.")]//Valicaciones
        [StringLength(100, MinimumLength = 5, ErrorMessage = "La contraseña debe contener un mínimo de 5 caracteres.")]
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        //Posición 3
        [DisplayName("Nombre")]//Nombre a visualizar.
        [Browsable(false)]//Ocultar visualización
        [Required(ErrorMessage = "Por favor ingrese nombre")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "El nombre debe ser solo letras")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe contener un mínimo de 3 caracteres.")]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        //Posición 4
        [DisplayName("DUI")]//Nombre a visualizar.
        [Browsable(false)]//Ocultar visualización
        [Required(ErrorMessage = "Por favor ingrese DUI.")]//Validaciones
        [StringLength(100, MinimumLength = 10, ErrorMessage = "El apellido debe contener 10 digitos incluyendo guion")]
        public string DUI
        {
            get { return _DUI; }
            set { _DUI = value; }
        }

        [DisplayName("Direccion")]//Nombre a visualizar.
        [Browsable(false)]//Ocultar visualización
        [Required(ErrorMessage = "Por favor ingrese Direccion.")]//Validaciones
        public string Direction
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        //Posición 5
        [DisplayName("Telefono")]//Nombre a visualizar.
        [Browsable(false)]//Ocultar visualización
        [Required(ErrorMessage = "Por favor ingrese DUI.")]//Validaciones
        [StringLength(100, MinimumLength = 8, ErrorMessage = "El telefono debe contener 8 digitos incluyendo guion")]
        public string Phone
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        //Posición 6
        [DisplayName("Cargo")]
        [Required(ErrorMessage = "Por favor ingrese un cargo.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Last name must contain a minimum of 8 characters.")]
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        //Posición 7
        [DisplayName("Email")]//Nombre a visualizar.
        [Required(ErrorMessage = "Por favor ingrese correo electrónico.")]//Validaciones
        [EmailAddress(ErrorMessage = "Ingrese un correo electrónico válido: example@gmail.com")]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

       
        #endregion

        #region -> Métodos Públicos

        public UserModel Login(string username, string password)
        {//Iniciar sesion.
            var result = _userDao.Login(username, password);
            if (result != null)
                return MapUserModel(result);
            else
                return null;
        }
        public bool ValidateActiveUser()
        {//Seguridad
            return _userDao.ValidateActiveUser();
        }

        public int CreateUser()
        {//Agregar nuevo usuario.
            //...
            //Aqui podría colocar su logica y reglas de negocio si es el caso.
            //..
            User userEntity = MapUserEntity(this);
            return _userDao.CreateUser(userEntity);
        }
        public int ModifyUser()
        {//Actualizar usuario.

            //...
            //Aqui podría colocar su logica y reglas de negocio si es el caso.
            //..
            User userEntity = MapUserEntity(this);
            return _userDao.ModifyUser(userEntity);
        }
        public int RemoveUser(int id)
        {//Eliminar usuario.

            //...
            //Aqui podría colocar su logica y reglas de negocio si es el caso.
            //..
            return _userDao.RemoveUser(id);
        }
        public UserModel GetUserById(int id)
        {//Obtener usuario por ID.
            var result = _userDao.GetUserById(id);
            if (result != null)
                return MapUserModel(result);
            else
                return null;
        }
        public IEnumerable<UserModel> GetAllUsers()
        {//Listar todos los usuarios.

           
            var result = _userDao.GetAllUsers();
            //...
            //Aqui podría colocar su logica y reglas de negocio si es el caso.
            //..
            return MapUserModel(result);
        }
        /*public UserModel RecoverPassword(string requestingUser)
        {//Método para recupear la contraseña del usuario y enviarlo a su dirección de correo.
            var result = _userDao.GetUserByUsername(requestingUser);
            if (result != null)
            {
                var userModel = MapUserModel(result);
                //var mailService = new EmailService();
                //mailService.Send(
                //    recipient: userModel.Email,
                  //  subject: "Solicitud de recuperación de contraseña",
                 //   body: "Hola " + userModel.FirstName + ",\nSolicitó recuperar su contraseña.\n" +
                 //   "Tu contraseña actual es: " + userModel.Password + "\nSin embargo, le pedimos que cambie" +
                 //   "su contraseña inmediatamente una vez ingrese a la aplicacíon");
               // return userModel;
            }
            else
                return null;
            /*Nota: Eso es simplemente un ejemplo para enviar correos electrónicos,
             * no es buena idea enviar directamente la contraseña del usuario,
             * en su lugar, es mejor enviar una contraseña temporal.
        }*/

        #endregion

        #region -> Métodos Privados (Mapear datos)

        //Mapear modelo de dominio a modelo de entidad.
        private User MapUserEntity(UserModel userModel)
        {
            var userEntity = new User
            {
                Id = userModel.Id,
                Username = userModel.Username,
                Password = userModel.Password,
                FirstName = userModel.FirstName,
                DUI = userModel.DUI,
                Phone = userModel.Phone,
                Position = userModel.Position,
                Email = userModel.Email
            };
            return userEntity;
        }

        //Mapear modelo entidad a modelo de dominio.
        private UserModel MapUserModel(User userEntity)
        {//Mapear un solo objeto.
            var userModel = new UserModel()
            {
                Id = userEntity.Id,
                Username = userEntity.Username,
                Password = userEntity.Password,
                FirstName = userEntity.FirstName,
                DUI = userEntity.DUI,
                Position = userEntity.Position,
                Email = userEntity.Email
            };
            return userModel;
        }
        private IEnumerable<UserModel> MapUserModel(IEnumerable<User> userEntities)
        {//Mapear colección de objetos.
            var userModels = new List<UserModel>();
            foreach (var user in userEntities)
            {
                userModels.Add(MapUserModel(user));
            }
            return userModels;
        }

        #endregion

    }
}
