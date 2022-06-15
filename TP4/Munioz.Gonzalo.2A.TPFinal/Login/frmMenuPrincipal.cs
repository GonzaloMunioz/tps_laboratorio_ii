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
            _ = controladorCliente + new Cliente(new DateTime(2022, 09, 18), "Paulo", "Dybala", "25347618", "Av. San Martín 458");
            _ = controladorCliente + new Cliente(new DateTime(2022, 10, 03), "Lionel", "Messi", "24787899", "Rosales 23");
            _ = controladorCliente + new Cliente(new DateTime(2022, 08, 05), "Cristian", "Romero", "33257891", "Jorge 742");
            _ = controladorCliente + new Cliente(new DateTime(2022, 07, 21), "Lautaro", "Martínez", "37845269", "Av. Libertador 655");
            _ = controladorCliente + new Cliente(new DateTime(2022, 06, 29), "Rodrigo", "De Paul", "23697845", "Tomás Nother 81");
            _ = controladorCliente + new Cliente(new DateTime(2022, 06, 29), "Leandro", "Paredes", "41257891", "Bynnon 1429");
            _ = controladorProducto + new Producto("Natura", 580, "Crema corporal");
            _ = controladorProducto + new Producto("Sedal", 1500, "Shampoo");
            _ = controladorProducto + new Producto("Dove", 350, "Jabón");
            _ = controladorProducto + new Producto("Colgate", 150, "Pasta dental");
            Refrescar();
        }

        private void lblAgregarCliente_Click(object sender, EventArgs e)
        {
            frmAgregarCliente frmAgregarCliente = new frmAgregarCliente(controladorCliente);

            if (frmAgregarCliente.ShowDialog() == DialogResult.No)
            {
                frmAgregarCliente.Cliente.UltimoID--;
                MessageBox.Show("El cliente ya se encuentra en el sistema", "Error");
            }
            Refrescar();
        }

        private void lblBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente frmModificarCliente = new frmBuscarCliente(controladorCliente);
            frmModificarCliente.ShowDialog();
        }

        private void lblListarInformacion_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void lblProductos_Click(object sender, EventArgs e)
        {
            frmMenuProductos frmMenuProductos = new frmMenuProductos(controladorProducto, controladorCliente);

            if (frmMenuProductos.ShowDialog() == DialogResult.No)
            {
                MessageBox.Show("El producto ya se encuentra en el sistema");
            }
            Refrescar();
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSerializarXML_Click(object sender, EventArgs e)
        {
            try
            {
                SerializadoraXML<Controlador<Cliente>> serializadoraXMLClientes = new SerializadoraXML<Controlador<Cliente>>();
                SerializadoraXML<Controlador<Producto>> serializadoraXMLProductos = new SerializadoraXML<Controlador<Producto>>();
                serializadoraXMLClientes.Serializar(controladorCliente, "Lista-Clientes");
                serializadoraXMLProductos.Serializar(controladorProducto, "Lista-Productos");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error a la hora de serializar los archivos: {ex.Message}", "Error");
            }
        }

        private void btnSerializarJSON_Click(object sender, EventArgs e)
        {
            try
            {
                SerializadoraJSON<Controlador<Cliente>> serializadoraJSONClientes = new SerializadoraJSON<Controlador<Cliente>>();
                SerializadoraJSON<Controlador<Producto>> serializadoraJSONProductos = new SerializadoraJSON<Controlador<Producto>>();
                serializadoraJSONClientes.Serializar(controladorCliente, "Lista-Clientes");
                serializadoraJSONProductos.Serializar(controladorProducto, "Lista-Productos");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error a la hora de serializar los archivos: {ex.Message}", "Error");
            }
        }

        private void btnDeserializarXML_Click(object sender, EventArgs e)
        {
            try
            {
                SerializadoraXML<Controlador<Cliente>> serializadoraXMLClientes = new SerializadoraXML<Controlador<Cliente>>();
                SerializadoraXML<Controlador<Producto>> serializadoraXMLProductos = new SerializadoraXML<Controlador<Producto>>();
                controladorCliente.Concatenar(serializadoraXMLClientes.Deserializar("Lista-Clientes"));
                controladorProducto.Concatenar(serializadoraXMLProductos.Deserializar("Lista-Productos"));
                Refrescar();
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
                controladorCliente.Concatenar(serializadoraJSONClientes.Deserializar("Lista-Clientes"));
                controladorProducto.Concatenar(serializadoraJSONProductos.Deserializar("Lista-Productos"));
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error a la hora de deserializar los archivos: {ex.Message}", "Error");
            }
        }

        private void Refrescar()
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
                if(cliente.Turno < DateTime.Today)
                {
                    rtbProximosTurnos.Text += $"Ø Cliente: {cliente.NombreCompleto}\n" +
                                              $"Ø Turno: {cliente.Turno.ToShortDateString()} (VENCIDO)\n\n";
                }
                else
                {
                    rtbProximosTurnos.Text += (string)cliente + "\n";
                }
            }
        }
    }
}
