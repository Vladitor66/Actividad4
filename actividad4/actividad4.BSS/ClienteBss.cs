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
                return dal.ListarClientesDal();
            }
            public void InsertarClienteBss(ClienteDal cliente)
            {
                dal.InsertarClienteDal(cliente);
            }
            public Cliente ObtenerIdBss(int id)
            {
                return dal.ObtenerClienteId(id);
            }
            public void EditarPersonaBss(Cliente c)
            {
                dal.EditarClienteDal(c);
            }
            public void EliminarClienteBss(int id)
            {
                dal.EliminarClienteDal(id);
            }

        }
    }
