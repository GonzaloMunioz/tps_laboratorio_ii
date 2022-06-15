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
    public partial class frmModificarCliente : Form
    {
        Cliente cliente;
        Controlador<Cliente> controladorCliente;

        public frmModificarCliente(Cliente cliente, Controlador<Cliente> controladorCliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.controladorCliente = controladorCliente;
        }

        private void frmModificarCliente_Load(object sender, EventArgs e)
        {
            rtbCliente.Text += cliente.ToString();
            dtpTurno.Value = cliente.Turno;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                cliente.Nombre = tbNombre.Text;
            }
            if (!string.IsNullOrWhiteSpace(tbApellido.Text))
            {
                cliente.Apellido = tbApellido.Text;
            }
            if (!string.IsNullOrWhiteSpace(tbDNI.Text))
            {
                if (tbDNI.Text.ValidarDNI())
                {
                    cliente.Dni = tbDNI.Text;
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un D.N.I. válido", "Error");
                }
            }
            if (!string.IsNullOrWhiteSpace(tbDireccion.Text))
            {
                cliente.Direccion = tbDireccion.Text;
            }
            if (cliente.Turno != dtpTurno.Value)
            {
                if (DateTime.Today < dtpTurno.Value)
                {
                    cliente.Turno = dtpTurno.Value;
                }
                else
                {
                    MessageBox.Show("Por favor ingrese una fecha válida", "Error");
                }
            }

            rtbCliente.Clear();
            rtbCliente.Text += cliente.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar este cliente del sistema? Esto hará que no se pueda recuperar", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                controladorCliente.ListaDeElementos.Remove(cliente);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }
    }
}
