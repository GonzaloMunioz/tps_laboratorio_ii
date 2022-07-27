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
    public partial class frmMenuPrincipal : Form
    {
        string usuario;
        Controlador<Cliente> controladorCliente;
        Controlador<Producto> controladorProducto;

        public frmMenuPrincipal(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            controladorCliente = new Controlador<Cliente>();
            controladorProducto = new Controlador<Producto>();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuario.ToUpper();
            _ = controladorCliente + new Cliente(new DateTime(2022, 09, 18), "Diego", "Maradona", "28747618", "Av. San Martín 458");
            _ = controladorCliente + new Cliente(new DateTime(2022, 10, 03), "Juan Román", "Riquelme", "29587399", "Rosales 23");
            _ = controladorCliente + new Cliente(new DateTime(2022, 08, 05), "Fernando", "Redondo", "24295421", "Jorge 742");
            _ = controladorCliente + new Cliente(new DateTime(2022, 07, 21), "Cristiano", "Ronaldo", "17545281", "Av. Libertador 655");

            _ = controladorProducto + new Producto("Plusbelle", 1500, "Shampoo");
            _ = controladorProducto + new Producto("Rexona", 800, "Crema aftershave");
            _ = controladorProducto + new Producto("Natura", 500, "Bálsamo hidratante");
            _ = controladorProducto + new Producto("Vogue", 1000, "Delineador");
            
            Refrescar();
        }

        private void lblAgregarCliente_Click(object sender, EventArgs e)
        {
            frmAgregarCliente frmAgregarCliente = new frmAgregarCliente(controladorCliente);
            if (frmAgregarCliente.ShowDialog() == DialogResult.No)
            {
                frmAgregarCliente.Cliente.UltimoID--;
                MessageBox.Show("El cliente ya se encuentra en el sistema", "Error");
            }
            Refrescar();
        }

        private void lblBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente frmModificarCliente = new frmBuscarCliente(controladorCliente);
            Task tarea = new Task(() => frmModificarCliente.ShowDialog()); // TEMA 19 - PROGRAMACIÓN MULTI-HILO, TEMA 18 - EXPRESIONES LAMBDA
            tarea.Start();
            Refrescar();
        }

        private void lblListarInformacion_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void lblProductos_Click(object sender, EventArgs e)
        {
            frmMenuProductos frmMenuProductos = new frmMenuProductos(controladorProducto, controladorCliente);

            if (frmMenuProductos.ShowDialog() == DialogResult.No)
            {
                MessageBox.Show("El producto ya se encuentra en el sistema");
            }
            Refrescar();
        }

        private void lblImportarExportarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                frmGuardarLeerDatos frmGuardarLeerDatos = new frmGuardarLeerDatos(controladorCliente, controladorProducto);
                Task tarea = Task.Run(() => frmGuardarLeerDatos.ShowDialog()); // TEMA 19 - PROGRAMACIÓN MULTI-HILO, TEMA 18 - EXPRESIONES LAMBDA
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error a la hora de manipular los datos \nMensaje de error: {ex.Message}", "¡Error!");
            }
            
        }

        private void lblRecuperarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                frmAltaBaja frmAltaBaja = new frmAltaBaja();
                frmAltaBaja.ShowDialog();
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error a la hora de manipular los datos \nMensaje de error: {ex.Message}", "¡Error!");
            }
        }
        private void Refrescar()
        {
            List<Cliente> listaClonada = new List<Cliente>(controladorCliente.ListaDeElementos);
            listaClonada.Sort((x, y) => DateTime.Compare(x.Turno, y.Turno));

            rtbListaClientes.Clear();
            rtbProductos.Clear();
            rtbProximosTurnos.Clear();

            rtbListaClientes.Text += controladorCliente.ToString();
            rtbProductos.Text += controladorProducto.ToString();
            foreach (Cliente cliente in listaClonada)
            {
                if(cliente.Turno < DateTime.Today)
                {
                    rtbProximosTurnos.Text += $"Ø Cliente: {cliente.NombreCompleto}\n" +
                                              $"Ø Turno: {cliente.Turno.ToShortDateString()} (VENCIDO)\n\n";
                }
                else
                {
                    rtbProximosTurnos.Text += (string)cliente + "\n";
                }
            }
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
