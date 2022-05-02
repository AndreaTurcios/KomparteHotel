using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komparte.classes.dao;
using System.Data;
using Komparte.classes.entidades;
using Komparte.classes.filter;

namespace Komparte.classes.model
{
    class ClienteModel
    {
        private ClienteDao clienteDao = new ClienteDao();

        public DataTable f_all_clientes() 
        {
            DataTable tabla = new DataTable();
            tabla = clienteDao.all_clientes();
            return tabla;
        }

        public int f_create_cliente(Cliente cli)
        {
            int result;
            result = clienteDao.create_cliente(cli);
            return result;
        }

        public Cliente fClienteById(string srt) {
            Cliente cli = clienteDao.get_cliente_by_id(Int32.Parse(srt));
            return cli;
        }

        public int f_update_cliente(Cliente cli) 
        {
            int result;
            result = clienteDao.edit_cliente(cli);
            return result;
        }

        public int f_delete_cliente(string srt) 
        {
            int result;
            result = clienteDao.simply_delete_cliente(Int32.Parse(srt));
            return result;
        }
    }
}
