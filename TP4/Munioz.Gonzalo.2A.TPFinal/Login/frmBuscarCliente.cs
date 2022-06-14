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
    public partial class frmBuscarCliente : Form
    {
        Controlador<Cliente> controladorCliente;

        public frmBuscarCliente(Controlador<Cliente> controladorCliente)
        {
            InitializeComponent();
            this.controladorCliente = controladorCliente;
        }

        private void frmModificarCliente_Load(object sender, EventArgs e)
        {
            rtbListaClientes.Text += controladorCliente.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmModificarCliente frmModificarCliente;

            if (!string.IsNullOrWhiteSpace(tbIngreseID.Text))
            {
                foreach (Cliente cliente in controladorCliente.ListaDeElementos)
                {
                    if(cliente.Id == int.Parse(tbIngreseID.Text))
                    {
                        frmModificarCliente = new frmModificarCliente(cliente, controladorCliente);
                        frmModificarCliente.ShowDialog();
                        if (frmModificarCliente.DialogResult == DialogResult.OK)
                        {
                            MessageBox.Show("La operación se ha realizado con éxito", "Éxito");
                        }
                    }
                }
                rtbListaClientes.Clear();
                rtbListaClientes.Text += controladorCliente.ToString();
            }
            else
            {
                MessageBox.Show("No existe un cliente con el ID ingresado", "Error");
            }
        }

        private void tbIngreseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
