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
    public partial class frmLogin : Form
    {
        List<Usuario> listaDeUsuariosRegistrados;

        public frmLogin()
        {
            InitializeComponent();
            listaDeUsuariosRegistrados = new List<Usuario>();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbUsuario.Text) || string.IsNullOrWhiteSpace(tbContrasenia.Text))
            {
                MessageBox.Show(frmRegistro.Validar(".", ".", tbUsuario.Text, tbContrasenia.Text, ".", ".", ".", "."));
            }
            else
            {
                Usuario usuarioActual = new Usuario(tbUsuario.Text.ToLower(), tbContrasenia.Text, ".", ".", DateTime.Today);
                foreach (Usuario usuario in listaDeUsuariosRegistrados)
                {
                    if(usuarioActual == usuario)
                    {
                        frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal(tbUsuario.Text);
                        this.Hide();
                        this.DialogResult = DialogResult.OK;
                        frmMenuPrincipal.ShowDialog();
                    }
                }
                if(this.DialogResult != DialogResult.OK)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Atencion");
                }
            }
        }

        private void lblRegistrarNuevoUsuario_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            if(frmRegistro.ShowDialog() == DialogResult.OK)
            {
                listaDeUsuariosRegistrados.Add(frmRegistro.Usuario);
                MessageBox.Show("Se ha registrado un nuevo usuario exitosamente", "Atención");
            }
        }

    }
}
