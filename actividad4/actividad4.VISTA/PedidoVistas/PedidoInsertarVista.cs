using actividad4.BSS;
using actividad4.MODELOS;
using actividad4.VISTA.ClienteVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actividad4.VISTA.PedidoVistas
{
    public partial class PedidoInsertarVista : Form
    {
        public PedidoInsertarVista()
        {
            InitializeComponent();
        }
        PedidoBss bss = new PedidoBss();

        private void button1_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.IDCliente = IdClienteSeleccionado;
            pedido.Fecha = dateTimePicker1.Value;
            pedido.Total = Convert.ToDecimal(textBox2.Text);
            pedido.Estado = textBox3.Text;

            bss.InsertarPedidoBss(pedido);
            MessageBox.Show("Se guardo correctamente el Detalle Ingreso");

        }
        public static int IdClienteSeleccionado = 0;
        ClienteBss bsscliente = new ClienteBss();

        private void button3_Click(object sender, EventArgs e)
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bsscliente.ObtenerClientePorIdBss(IdClienteSeleccionado);
                textBox1.Text = cliente.Nombre;
            }

        }

        private void PedidoInsertarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
