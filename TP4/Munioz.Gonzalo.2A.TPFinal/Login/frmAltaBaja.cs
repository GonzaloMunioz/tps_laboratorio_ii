using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiEstetica
{
    public partial class frmAltaBaja : Form
    {
        Controlador<Cliente> controladorClientesActivos;
        Controlador<Cliente> controladorClientesInactivos;

        public frmAltaBaja()
        {
            InitializeComponent();
            controladorClientesActivos = new Controlador<Cliente>();
            controladorClientesInactivos = new Controlador<Cliente>();
        }
        private void frmAltaBaja_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(tbIDBaja.Text))
            {
                ClienteDBManager.Baja(int.Parse(tbIDBaja.Text));
                Refrescar();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbIDAlta.Text))
            {
                ClienteDBManager.Alta(int.Parse(tbIDAlta.Text));
                Refrescar();
            }
        }

        private void tbIDBaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbIDAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Refrescar()
        {
            controladorClientesActivos = ClienteDBManager.Leer(1);
            controladorClientesInactivos = ClienteDBManager.Leer(0);

            rtbClientesActivos.Clear();
            rtbClientesInactivos.Clear();

            rtbClientesActivos.Text += controladorClientesActivos.ToString();
            rtbClientesInactivos.Text += controladorClientesInactivos.ToString();
        }
    }
}
