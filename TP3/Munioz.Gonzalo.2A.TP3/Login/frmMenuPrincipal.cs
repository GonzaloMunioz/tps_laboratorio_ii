using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiEstetica
{
    public partial class frmMenuPrincipal : Form
    {
        string usuario;
        Controlador<Cliente> controladorCliente;
        Controlador<Producto> controladorProducto;

        public frmMenuPrincipal(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            controladorCliente = new Controlador<Cliente>();
            controladorProducto = new Controlador<Producto>();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuario.ToUpper();
        }

        private void lblAgregarCliente_Click(object sender, EventArgs e)
        {
            frmAgregarCliente frmAgregarCliente = new frmAgregarCliente(controladorCliente);

            if (frmAgregarCliente.ShowDialog() == DialogResult.No)
            {
                frmAgregarCliente.Cliente.UltimoID--;
                MessageBox.Show("El cliente ya se encuentra en el sistema", "Error");
            }
        }

        private void lblBuscarCliente_Click(object sender, EventArgs e)
        {
            if (controladorCliente.CantidadDeElementos > 0)
            {
                frmBuscarCliente frmModificarCliente = new frmBuscarCliente(controladorCliente);
                frmModificarCliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay ningún cliente registrado en el sistema", "Error");
            }
        }

        private void lblListarInformacion_Click(object sender, EventArgs e)
        {
            List<Cliente> listaClonada = new List<Cliente>(controladorCliente.ListaDeElementos);
            listaClonada.Sort((x, y) => DateTime.Compare(x.Turno, y.Turno));

            rtbListaClientes.Clear();
            rtbProductos.Clear();
            rtbProximosTurnos.Clear();

            rtbListaClientes.Text += controladorCliente.ToString();
            rtbProductos.Text += controladorProducto.ToString();
            foreach (Cliente cliente in listaClonada)
            {
                rtbProximosTurnos.Text += (string)cliente + "\n";
            }
        }

        private void lblProductos_Click(object sender, EventArgs e)
        {
            frmMenuProductos frmMenuProductos = new frmMenuProductos(controladorProducto, controladorCliente);

            if (frmMenuProductos.ShowDialog() == DialogResult.No)
            {
                MessageBox.Show("El producto ya se encuentra en el sistema");
            }
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSerializarXML_Click(object sender, EventArgs e)
        {
            if (controladorCliente.CantidadDeElementos > 0 && controladorProducto.CantidadDeElementos > 0)
            {
                SerializadoraXML<Controlador<Cliente>> serializadoraXMLClientes = new SerializadoraXML<Controlador<Cliente>>();
                SerializadoraXML<Controlador<Producto>> serializadoraXMLProductos = new SerializadoraXML<Controlador<Producto>>();
                serializadoraXMLClientes.Serializar(controladorCliente, "Lista-Clientes");
                serializadoraXMLProductos.Serializar(controladorProducto, "Lista-Productos");
            }
            else
            {
                MessageBox.Show("Por favor, primero registre al menos un cliente y un producto en el sistema", "Error");
            }
        }

        private void btnSerializarJSON_Click(object sender, EventArgs e)
        {
            if (controladorCliente.CantidadDeElementos > 0 && controladorProducto.CantidadDeElementos > 0)
            {
                SerializadoraJSON<Controlador<Cliente>> serializadoraJSONClientes = new SerializadoraJSON<Controlador<Cliente>>();
                SerializadoraJSON<Controlador<Producto>> serializadoraJSONProductos = new SerializadoraJSON<Controlador<Producto>>();
                serializadoraJSONClientes.Serializar(controladorCliente, "Lista-Clientes");
                serializadoraJSONProductos.Serializar(controladorProducto, "Lista-Productos");
            }
            else
            {
                MessageBox.Show("Por favor, primero registre al menos un cliente y un producto en el sistema", "Error");
            }
        }

        private void btnDeserializarXML_Click(object sender, EventArgs e)
        {
            try
            {
                SerializadoraXML<Controlador<Cliente>> serializadoraXMLClientes = new SerializadoraXML<Controlador<Cliente>>();
                SerializadoraXML<Controlador<Producto>> serializadoraXMLProductos = new SerializadoraXML<Controlador<Producto>>();
                controladorCliente = serializadoraXMLClientes.Deserializar("Lista-Clientes");
                controladorProducto = serializadoraXMLProductos.Deserializar("Lista-Productos");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error a la hora de deserializar los archivos: {ex.Message}", "Error");
            }

        }

        private void btnDeserializarJSON_Click(object sender, EventArgs e)
        {
            try
            {
                SerializadoraJSON<Controlador<Cliente>> serializadoraJSONClientes = new SerializadoraJSON<Controlador<Cliente>>();
                SerializadoraJSON<Controlador<Producto>> serializadoraJSONProductos = new SerializadoraJSON<Controlador<Producto>>();
                controladorCliente = serializadoraJSONClientes.Deserializar("Lista-Clientes");
                controladorProducto = serializadoraJSONProductos.Deserializar("Lista-Productos");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error a la hora de deserializar los archivos: {ex.Message}", "Error");
            }
        }
    }
}
