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

namespace MenuPrincipal
{
    public partial class frmMenuPrincipal : Form
    {
        List<Cliente> listaDeClientes;

        public frmMenuPrincipal()
        {
            InitializeComponent();
            listaDeClientes = new List<Cliente>();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void lblAgregarCliente_Click(object sender, EventArgs e)
        {

        }

        private void lblEntrada_Click(object sender, EventArgs e)
        {

        }

        private void lblSalida_Click(object sender, EventArgs e)
        {

        }

        private void lblProductos_Click(object sender, EventArgs e)
        {

        }

        private void lblListarClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
