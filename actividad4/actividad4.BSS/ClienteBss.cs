using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using actividad4.BSS;
using actividad4.DAL;
using actividad4.MODELOS;

namespace actividad4.BSS
{
    public class ClienteBss
    {
        ClienteDal dal = new ClienteDal();

        public DataTable ListarClienteBss()
        {
            return dal.ListarClientes();
        }

        public void InsertarClienteBss(Cliente cliente)
        {
            dal.InsertarCliente(cliente);
        }

        public Cliente ObtenerClientePorIdBss(int id)
        {
            return dal.ObtenerClientePorId(id);
        }

        public void EditarClienteBss(Cliente cliente)
        {
            dal.EditarCliente(cliente);
        }

        public void EliminarClienteBss(int id)
        {
            dal.EliminarCliente(id);
        }
    }
}
