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
    public partial class frmVender : Form
    {
        Controlador<Cliente> controladorCliente;
        Controlador<Producto> controladorProducto;

        public frmVender(Controlador<Cliente> controladorCliente, Controlador<Producto> controladorProducto)
        {
            InitializeComponent();
            this.controladorCliente = controladorCliente;
            this.controladorProducto = controladorProducto;
        }

        private void frmVender_Load(object sender, EventArgs e)
        {
            foreach (Cliente cliente in controladorCliente.ListaDeElementos)
            {
                lbClientes.Items.Add(cliente.NombreCompleto);
            }

            foreach (Producto producto in controladorProducto.ListaDeElementos)
            {
                lbProductos.Items.Add($"{producto.Descripcion}, {producto.Marca} - STOCK: {producto.Cantidad}un.");
            }
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
            Cliente clienteAux;
            Producto productoAux;
            int cantidadParseada;

            if (lbProductos.SelectedIndex > -1 && lbClientes.SelectedIndex > -1 && !string.IsNullOrWhiteSpace(tbCantidad.Text))
            {
                cantidadParseada = int.Parse(tbCantidad.Text);
                clienteAux = controladorCliente.ListaDeElementos.ElementAt(lbClientes.SelectedIndex);
                productoAux = controladorProducto.ListaDeElementos.ElementAt(lbProductos.SelectedIndex);

                if (cantidadParseada <= productoAux.Cantidad && cantidadParseada > 0)
                {
                    productoAux.Cantidad = productoAux.Cantidad - cantidadParseada;
                    ProductoDBManager.Modificacion(productoAux);
                    MessageBox.Show(GenerarFactura(clienteAux.NombreCompleto, clienteAux.Dni, productoAux.Descripcion, productoAux.Marca, cantidadParseada, (cantidadParseada * productoAux.PrecioVenta)));
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("No hay existencias suficientes de ese producto", "Error");
                }
            }
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            Producto productoAux;
            float cantidadParseada;

            if (lbProductos.SelectedIndex > -1 && !string.IsNullOrWhiteSpace(tbCantidad.Text))
            {
                productoAux = controladorProducto.ListaDeElementos.ElementAt(lbProductos.SelectedIndex);
                cantidadParseada = float.Parse(tbCantidad.Text) * productoAux.PrecioVenta;
                lblPrecioTotal.Text = "$ " + cantidadParseada.ToString();
            }
        }

        private string GenerarFactura(string nombre, string dni, string descripcion, string marca, int cantidad, float precio)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"    \t\tBEAUTY LIFE");
            sb.AppendLine($" \tDirección: Av. Las Heras 345");
            sb.AppendLine($"    \t\tTel. : 11 5126-9941");
            sb.AppendLine($"     \t\tFecha: {DateTime.Today.ToShortDateString()}\n");
            sb.AppendLine($"************************************************");
            sb.AppendLine($"    \tTICKET DE COMPRA");
            sb.AppendLine($"************************************************\n");
            sb.AppendLine($"    \tDATOS DEL COMPRADOR");
            sb.AppendLine($"************************************************\n");
            sb.AppendLine($" Nombre: {nombre}");
            sb.AppendLine($" D.N.I.: {dni}\n");
            sb.AppendLine($"************************************************\n");
            sb.AppendLine($" Producto               \t\t\tCant.");
            sb.AppendLine($" {descripcion + ", " + marca}      \t\t{cantidad}\n");
            sb.AppendLine($"************************************************\n");
            sb.AppendLine($" Total                   \t\t\t  $ {precio}\n");
            sb.AppendLine($"************************************************\n");
            sb.AppendLine($"           \t\t¡Muchas gracias!");

            return sb.ToString();
        }
    }
}
