using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using actividad4.DAL;
using actividad4.MODELOS;


namespace actividad4.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClientes()
        {
            string consulta = "SELECT * FROM Cliente";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarCliente(Cliente cliente)
        {
            string consulta = "INSERT INTO Cliente (Nombre, Apellido, Correo, Telefono, Direccion) " +
                              "VALUES ('" + cliente.Nombre + "', '" + cliente.Apellido + "', '" + cliente.Correo + "', '" +
                              cliente.Telefono + "', '" + cliente.Direccion + "')";
            conexion.Ejecutar(consulta);
        }

        public Cliente ObtenerClientePorId(int id)
        {
            string consulta = "SELECT * FROM Cliente WHERE IDCliente = " + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            Cliente cliente = new Cliente();
            if (tabla.Rows.Count > 0)
            {
                cliente.IDCliente = Convert.ToInt32(tabla.Rows[0]["IDCliente"]);
                cliente.Nombre = tabla.Rows[0]["Nombre"].ToString();
                cliente.Apellido = tabla.Rows[0]["Apellido"].ToString();
                cliente.Correo = tabla.Rows[0]["Correo"].ToString();
                cliente.Telefono = tabla.Rows[0]["Telefono"].ToString();
                cliente.Direccion = tabla.Rows[0]["Direccion"].ToString();
            }
            return cliente;
        }

        public void EditarCliente(Cliente cliente)
        {
            string consulta = "UPDATE Cliente SET Nombre = '" + cliente.Nombre + "', " +
                              "Apellido = '" + cliente.Apellido + "', " +
                              "Correo = '" + cliente.Correo + "', " +
                              "Telefono = '" + cliente.Telefono + "', " +
                              "Direccion = '" + cliente.Direccion + "' " +
                              "WHERE IDCliente = " + cliente.IDCliente;
            conexion.Ejecutar(consulta);
        }

        public void EliminarCliente(int id)
        {
            string consulta = "DELETE FROM Cliente WHERE IDCliente = " + id;
            conexion.Ejecutar(consulta);
        }

    } 
}
