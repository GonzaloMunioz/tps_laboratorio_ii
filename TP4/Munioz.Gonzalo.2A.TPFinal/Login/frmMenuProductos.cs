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
    public partial class frmMenuProductos : Form
    {
        Producto producto;
        Controlador<Producto> controladorProducto;
        Controlador<Cliente> controladorCliente;

        public Producto Producto
        {
            get { return producto; }
        }

        public frmMenuProductos(Controlador<Producto> controladorProducto, Controlador<Cliente> controladorCliente)
        {
            InitializeComponent();
            this.controladorProducto = controladorProducto;
            this.controladorCliente = controladorCliente;
        }

        private void frmMenuProductos_Load(object sender, EventArgs e)
        {
            rtbListaProductos.Text += controladorProducto.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbMarca.Text) || string.IsNullOrWhiteSpace(tbPrecio.Text) || string.IsNullOrWhiteSpace(tbDescripcion.Text))
            {
                MessageBox.Show("Por favor complete todos los campos", "Error");
            }
            else
            {
                producto = new Producto(tbMarca.Text, float.Parse(tbPrecio.Text), tbDescripcion.Text);
                if(controladorProducto + producto)
                {
                    rtbListaProductos.Clear();
                    rtbListaProductos.Text += controladorProducto.ToString();
                }
                else
                {
                    this.DialogResult = DialogResult.No;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if(controladorProducto.CantidadDeElementos > 0)
            {
                frmComprar frmComprar = new frmComprar(controladorProducto);
                frmComprar.ShowDialog();
                rtbListaProductos.Clear();
                rtbListaProductos.Text += controladorProducto.ToString();
            }
            else
            {
                MessageBox.Show("No hay ningún producto registrado en el sistema", "Error");
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (controladorProducto.CantidadDeElementos > 0 && controladorCliente.CantidadDeElementos > 0)
            {
                frmVender frmVender = new frmVender(controladorCliente, controladorProducto);
                frmVender.ShowDialog();
                rtbListaProductos.Clear();
                rtbListaProductos.Text += controladorProducto.ToString();
            }
            else
            {
                MessageBox.Show("No hay ningún cliente y/o producto registrado en el sistema", "Error");
            }
        }
    }
}
