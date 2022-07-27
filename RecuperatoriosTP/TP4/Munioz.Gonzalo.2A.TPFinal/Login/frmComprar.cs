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
    public partial class frmComprar : Form
    {
        Controlador<Producto> controladorProducto;

        public frmComprar(Controlador<Producto> controladorProducto)
        {
            InitializeComponent();
            this.controladorProducto = controladorProducto;
        }

        private void frmComprar_Load(object sender, EventArgs e)
        {
            foreach (Producto producto in controladorProducto.ListaDeElementos)
            {
                lbProductos.Items.Add($"{producto.Descripcion}, { producto.Marca}");
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Producto productoAux;
            int cantidadParseada;

            if(lbProductos.SelectedIndex > -1 && !string.IsNullOrWhiteSpace(tbCantidad.Text))
            {
                productoAux = controladorProducto.ListaDeElementos.ElementAt(lbProductos.SelectedIndex);
                cantidadParseada = int.Parse(tbCantidad.Text);
                if(cantidadParseada > 0)
                {
                    productoAux.Cantidad = cantidadParseada;
                    ProductoDBManager.Modificacion(productoAux);
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            Producto productoAux;
            float cantidadParseada;

            if (!string.IsNullOrWhiteSpace(tbCantidad.Text) && lbProductos.SelectedIndex > -1)
            {
                productoAux = controladorProducto.ListaDeElementos.ElementAt(lbProductos.SelectedIndex);
                cantidadParseada = float.Parse(tbCantidad.Text) * productoAux.Precio;
                lblCostoTotal.Text = "$ " + cantidadParseada.ToString();
            }
        }

        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }        
    }
}
