using actividad4.DAL;
using actividad4.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad4.BSS
{
    public class PedidoBss
    {
        PedidoDal dal = new PedidoDal();

        public DataTable ListarPedidoBss()
        {
            return dal.ListarPedidos();
        }

        public void InsertarPedidoBss(Pedido pedido)
        {
            dal.InsertarPedido(pedido);
        }

        public Pedido ObtenerPedidoPorIdBss(int id)
        {
            return dal.ObtenerPedidoPorId(id);
        }

        public void EditarPedidoBss(Pedido pedido)
        {
            dal.EditarPedido(pedido);
        }

        public void EliminarPedidoBss(int id)
        {
            dal.EliminarPedido(id);
        }
        public DataTable CalcularPedidosClienteBss(int ID)
        {
            return dal.CalcularTotalClienteDal(ID);
        }

    }
}

    

