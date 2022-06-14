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
    public partial class frmAgregarCliente : Form
    {
        Cliente cliente;
        Controlador<Cliente> controladorCliente;

        public Cliente Cliente
        {
            get { return cliente; }
        }

        public frmAgregarCliente(Controlador<Cliente> controladorCliente)
        {
            InitializeComponent();
            this.controladorCliente = controladorCliente;
        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
         
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text) || string.IsNullOrWhiteSpace(tbApellido.Text) || string.IsNullOrWhiteSpace(tbDNI.Text) || string.IsNullOrWhiteSpace(tbDireccion.Text))
            {
                MessageBox.Show(frmRegistro.Validar(tbNombre.Text, tbApellido.Text, ".", ".", ".", ".", tbDNI.Text, tbDireccion.Text));
            }
            else
            {
                if (tbDNI.Text.ValidarDNI())
                {
                    if (DateTime.Today < dtpTurno.Value)
                    {
                        cliente = new Cliente(dtpTurno.Value, tbNombre.Text, tbApellido.Text, tbDNI.Text, tbDireccion.Text);
                        if (controladorCliente + cliente)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            this.DialogResult = DialogResult.No;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese una fecha válida", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un D.N.I. válido", "Error");
                }
            }
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
