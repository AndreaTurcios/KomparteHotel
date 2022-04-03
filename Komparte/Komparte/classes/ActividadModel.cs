using DataAccess.DBServices;
using DataAccess.DBServices.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komparte.classes
{
    class ActividadModel
    {

        #region -> Atributos

        private int _id;
        private string _actividad;
        private ActivityDao _activityDao;
        #endregion


        #region -> Constructores

        public ActividadModel()
        {
            _activityDao = new ActivityDao();
        }

        public ActividadModel(int id, string actividad)
        {
            Id = id;
            Actividad = actividad;
            _activityDao = new ActivityDao();
        }
        #endregion

        #region -> Propiedades + Validacíon y Visualización de Datos

        //Posición 0 
        [DisplayName("Id")]//Nombre a visualizar (Por ejemplo en la columna del datagridview se mostrará como Num).
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        //Posición 1 
        [DisplayName("Actividad")]//Nombre a visualizar.
        [Required(ErrorMessage = "El nombre de usuario es requerido.")]//Validaciones
        [StringLength(100, MinimumLength = 5, ErrorMessage = "El nombre de usuario debe contener un mínimo de 5 caracteres.")]
        public string Actividad
        {
            get { return _actividad; }
            set { _actividad = value; }
        }


        #endregion

        #region -> Métodos Públicos

        /*private ActivityDao MapActivityEntity(ActividadModel actividadModel)
        {
            var activityEntity = new ActivityDao
            {
                Id = actividadModel.Id,
                Actividad = actividadModel.Actividad
            };
            return activityEntity;
        }


        public int CreateActivity()
        {//Agregar nuevo usuario.
            //...
            //Aqui podría colocar su logica y reglas de negocio si es el caso.
            //..
            ActividadModel activityEntity = MapActivityEntity(this);
            return _activityDao.CreateActivity(activityEntity);
        }*/
        /*public int ModifyActivity()
        {//Actualizar usuario.

            //...
            //Aqui podría colocar su logica y reglas de negocio si es el caso.
            //..
            User activityEntity = MapActivityEntity(this);
            return _activityDao.ModifyActivity(activityEntity);
        }*/
        //public int RemoveUser(int id)
        //{//Eliminar usuario.

            //...
            //Aqui podría colocar su logica y reglas de negocio si es el caso.
            //..
            //return _activityDao.RemoveActivity(id);
        }


       /* public ActividadModel GetActivityById(int id)
        {//Obtener usuario por ID.
            var result = _activityDao.GetUserById(id);
            if (result != null)
                return MapUserModel(result);
            else
                return null;
        }*/
        /*public IEnumerable<ActividadModel> GetActividadModels()
        {//Listar todos los usuarios.


            var result = _activityDao.GetAllActivity();
            //...
            //Aqui podría colocar su logica y reglas de negocio si es el caso.
            //..
            return MapActivityModel(result);
        }*/
        /*public UserModel RecoverPassword(string requestingUser)
        {//Método para recupear la contraseña del usuario y enviarlo a su dirección de correo.
            var result = _userDao.GetUserByUsername(requestingUser);
            if (result != null)
            {
                var userModel = MapUserModel(result);
                var mailService = new EmailService();
                mailService.Send(
                    recipient: userModel.Email,
                    subject: "Solicitud de recuperación de contraseña",
                    body: "Hola " + userModel.FirstName + ",\nSolicitó recuperar su contraseña.\n" +
                    "Tu contraseña actual es: " + userModel.Password + "\nSin embargo, le pedimos que cambie" +
                    "su contraseña inmediatamente una vez ingrese a la aplicacíon");
                return userModel;
            }
            else
                return null;
        }
        */
        #endregion

        #region -> Métodos Privados (Mapear datos)



        //Mapear modelo entidad a modelo de dominio.
       /* private ActividadModel MapActivityModel(Activity activity)
        {//Mapear un solo objeto.
            var userModel = new ActividadModel()
            {
                Id = activity.Id,
                Actividad = activity.Actividad
            };
            return userModel;
        }*/
       /* private IEnumerable<ActividadModel> MapUserModel(IEnumerable<Activity> Actividad)
        {//Mapear colección de objetos.
            var userModels = new List<ActividadModel>();
            foreach (var user in Actividad)
            {
                userModels.Add(MapActivityModel(activity));
            }
            return userModels;
        }*/

        #endregion

    //}
}
