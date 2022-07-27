using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiEstetica
{
    public partial class frmGuardarLeerDatos : Form
    {
        public delegate void DelegadoNotificarCardaDeDatos(); // TEMA 18 - DELEGADOS
        public event DelegadoNotificarCardaDeDatos DatosCargados; // TEMA 20 - EVENTOS

        Controlador<Cliente> controladorCliente;
        Controlador<Producto> controladorProducto;

        public frmGuardarLeerDatos(Controlador<Cliente> controladorCliente, Controlador<Producto> controladorProducto)
        {
            InitializeComponent();
            this.controladorCliente = controladorCliente;
            this.controladorProducto = controladorProducto;
        }

        private void frmGuardarLeerDatos_Load(object sender, EventArgs e)
        {
            DatosCargados += CerrarVentanas;
        }

        private void btnSerializarXML_Click(object sender, EventArgs e)
        {
            try
            {
                SerializadoraXML<Controlador<Cliente>> serializadoraXMLClientes = new SerializadoraXML<Controlador<Cliente>>();
                SerializadoraXML<Controlador<Producto>> serializadoraXMLProductos = new SerializadoraXML<Controlador<Producto>>();
                serializadoraXMLClientes.Serializar(controladorCliente, "Lista-Clientes");
                serializadoraXMLProductos.Serializar(controladorProducto, "Lista-Productos");
                MessageBox.Show("La serialización se ha realizado con éxtio", "Éxito");
                this.Close();
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
                DatosCargados.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error a la hora de deserializar los archivos: {ex.Message}", "Error");
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
                MessageBox.Show("La serialización se ha realizado con éxtio", "Éxito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error a la hora de serializar los archivos: {ex.Message}", "Error");
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
                DatosCargados.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error a la hora de deserializar los archivos: {ex.Message}", "Error");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (Cliente cliente in controladorCliente.ListaDeElementos)
            {
                ClienteDBManager.Cargar(cliente);
            }
            foreach (Producto producto in controladorProducto.ListaDeElementos)
            {
                ProductoDBManager.Cargar(producto);
            }
            MessageBox.Show("Se han cargado los datos del sistema en la base de datos correctamente", "Éxito");
            this.Close();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            controladorCliente.Concatenar(ClienteDBManager.Leer(1));
            controladorProducto.Concatenar(ProductoDBManager.Leer());
            DatosCargados.Invoke();
        }

        private void CerrarVentanas()
        {
            MessageBox.Show("Los datos han sido cargados correctamente", "¡Éxito!");
            this.Close();
        }
    }
}
