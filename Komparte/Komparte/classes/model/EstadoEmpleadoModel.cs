using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komparte.classes.dao;
using Komparte.classes.entidades;

namespace Komparte.classes.model
{
    class EstadoEmpleadoModel
    {
        #region -> Atributos

        private int _id;
        private string _estado;
        private EstadoEmpleadoDao _estadoEmpleadoDao;

        #endregion

        #region-> Constructores
            public EstadoEmpleadoModel()
        {
            _estadoEmpleadoDao = new EstadoEmpleadoDao();
        }

        public EstadoEmpleadoModel(int id, string estado)
        {
            idEstadoEmpleado = id;
            this.estado = estado;
            _estadoEmpleadoDao = new EstadoEmpleadoDao();
        }
        #endregion

        #region -> Visualizacion de Datos
            public int idEstadoEmpleado
        {
            get { return _id; }
            set { _id = value; }
        }

        public string estado {
            get { return _estado; }
            set { _estado = value; }
        }
        #endregion

        #region -> Métodos Públicos
        public IEnumerable<EstadoEmpleadoModel> GetAllEstadoEmpleados()
        {
            var result = _estadoEmpleadoDao.GetAllEstadoEmpleados();
            return MapsEstadoEmpleadoModel(result);
        }

        private IEnumerable<EstadoEmpleadoModel> MapsEstadoEmpleadoModel(IEnumerable<EstadoEmpleado> estadoEmpleadoEntities)
        {//Mapear colección de objetos.
            var EstadoEmpleadoModels = new List<EstadoEmpleadoModel>();
            foreach (var estadoEmpleado in estadoEmpleadoEntities)
            {
               // EstadoEmpleadoModels.Add(MapsEstadoEmpleadoModel(estadoEmpleado));
            }
            return EstadoEmpleadoModels;
        }

        #endregion
    }
}
