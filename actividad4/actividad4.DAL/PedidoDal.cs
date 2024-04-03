using actividad4.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad4.DAL
{
    public class PedidoDal
    {
        public DataTable ListarPedidos()
        {
            string consulta = "SELECT * FROM Pedidos";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarPedido(Pedido pedido)
        {
            string consulta = "INSERT INTO Pedidos (IDCliente, Fecha, Total, Estado) " +
                              "VALUES (" + pedido.IDCliente + ", '" + pedido.Fecha + "', " +
                              pedido.Total.ToString().Replace(',', '.') + ", '" + pedido.Estado + "')";
            conexion.Ejecutar(consulta);
        }

        public Pedido ObtenerPedidoPorId(int id)
        {
            string consulta = "SELECT * FROM Pedidos WHERE IDPedido = " + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            Pedido pedido = new Pedido();
            if (tabla.Rows.Count > 0)
            {
                pedido.IDPedido = Convert.ToInt32(tabla.Rows[0]["IDPedido"]);
                pedido.IDCliente = Convert.ToInt32(tabla.Rows[0]["IDCliente"]);
                pedido.Fecha = Convert.ToDateTime(tabla.Rows[0]["Fecha"]);
                pedido.Total = Convert.ToDecimal(tabla.Rows[0]["Total"]);
                pedido.Estado = tabla.Rows[0]["Estado"].ToString();
            }
            return pedido;
        }

        public void EditarPedido(Pedido pedido)
        {
            string consulta = "UPDATE Pedidos SET IDCliente = " + pedido.IDCliente + ", " +
                              "Fecha = '" + pedido.Fecha.ToString("yyyy-MM-dd") + "', " +
                              "Total = " + pedido.Total.ToString().Replace(',', '.') + ", " +
                              "Estado = '" + pedido.Estado + "' " +
                              "WHERE IDPedido = " + pedido.IDPedido;
            conexion.Ejecutar(consulta);
        }

        public void EliminarPedido(int id)
        {
            string consulta = "DELETE FROM Pedidos WHERE IDPedido = " + id;
            conexion.Ejecutar(consulta);
        }
        public DataTable CalcularTotalClienteDal(int id)
        {
            string consulta = "SELECT Cliente.Nombre, Cliente.Apellido, Count(Pedidos.IDPedido) AS PEDIDOS, sum(Pedidos.Total) AS CANTIDAD " +
                                "FROM Cliente INNER JOIN " +
                                                         "Pedidos ON Cliente.IDCliente = Pedidos.IDCliente " +
                               "WHERE cliente.IDCLIENTE = " + id +
                               "GROUP BY Cliente.Nombre, Cliente.Apellido ";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}
