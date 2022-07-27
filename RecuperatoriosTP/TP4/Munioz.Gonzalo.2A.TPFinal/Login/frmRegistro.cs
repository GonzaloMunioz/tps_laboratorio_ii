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
    public partial class frmRegistro : Form
    {
        Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
        }

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombre.Text) || string.IsNullOrWhiteSpace(tbApellido.Text) || string.IsNullOrWhiteSpace(tbUsuario.Text) || string.IsNullOrWhiteSpace(tbContrasenia.Text) || string.IsNullOrWhiteSpace(tbContraseniaRepetir.Text) || string.IsNullOrWhiteSpace(tbCorreoElectronico.Text))
            {
                MessageBox.Show(Validar(tbNombre.Text, tbApellido.Text, tbUsuario.Text, tbContrasenia.Text, tbContraseniaRepetir.Text, tbCorreoElectronico.Text, ".", "."));
            }
            else
            {
                if ((DateTime.Now.Year - dtpFechaDeNacimiento.Value.Year) > 17)
                {
                    if (ValidarCorreoElectronico(tbCorreoElectronico.Text))
                    {
                        if (tbContrasenia.Text == tbContraseniaRepetir.Text)
                        {
                            usuario = new Usuario(tbUsuario.Text.ToLower(), tbContrasenia.Text, tbNombre.Text.ToLower() + " " + tbApellido.Text.ToLower(), tbCorreoElectronico.Text.ToLower(), dtpFechaDeNacimiento.Value);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Las contraseñas no coinciden", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese un correo electrónico con un formato válido", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no puede ser menor a 18 años", "Atención");
                }
            }
        }

        public static string Validar(string nombre, string apellido, string usuario, string contrasenia, string contraseniaRepetir, string correoElectronico, string dni, string direccion)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Por favor ingrese el/los siguiente/s datos: ");

            if (string.IsNullOrEmpty(nombre))
            {
                sb.AppendLine(" - Nombre: ");
            }
            if (string.IsNullOrEmpty(apellido))
            {
                sb.AppendLine(" - Apellido: ");
            }
            if (string.IsNullOrEmpty(usuario))
            {
                sb.AppendLine(" - Usuario: ");
            }
            if (string.IsNullOrEmpty(contrasenia) || string.IsNullOrEmpty(contraseniaRepetir))
            {
                sb.AppendLine(" - Contraseña: ");
            }
            if (string.IsNullOrEmpty(correoElectronico))
            {
                sb.AppendLine(" - Dirección de correo electrónico: ");
            }
            if (string.IsNullOrEmpty(dni))
            {
                sb.AppendLine(" - D.N.I.: ");
            }
            if (string.IsNullOrEmpty(direccion))
            {
                sb.AppendLine(" - Dirección: ");
            }

            return sb.ToString();
        }

        public static bool ValidarCorreoElectronico(string correo)
        {
            foreach (char caracter in correo)
            {
                if (caracter == '@')
                {
                    return true;
                }
            }

            return false;
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
    }
}
