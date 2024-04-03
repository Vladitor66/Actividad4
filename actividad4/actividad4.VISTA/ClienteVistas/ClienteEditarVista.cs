using actividad4.BSS;
using actividad4.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actividad4.VISTA.ClienteVistas
{
    public partial class ClienteEditarVista : Form
    {
        int idx = 0;
        Cliente cliente = new Cliente();
        ClienteBss bss = new ClienteBss();

        public ClienteEditarVista(int id)
        {
            idx = id;

            InitializeComponent();
        }

        private void ClienteEditarVista_Load(object sender, EventArgs e)
        {
            cliente = bss.ObtenerClientePorIdBss(idx);
            textBox1.Text = cliente.Nombre;
            textBox2.Text = cliente.Apellido;
            textBox3.Text = cliente.Correo;
            textBox4.Text = cliente.Telefono;
            textBox5.Text = cliente.Direccion;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente.Nombre = textBox1.Text;
            cliente.Apellido = textBox2.Text;
            cliente.Correo = textBox3.Text;
            cliente.Telefono = textBox4.Text;
            cliente.Direccion = textBox5.Text;

            bss.EditarClienteBss(cliente);
            MessageBox.Show("Datos Actualizados");

        }
    }
}
