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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        // TODO : 1. Cambiar titulo de calculadora - DONE
        // TODO : 2. Cambiar nombre de la clase - DONE
        // TODO : 3. Limitar el maximize y minimize - DONE
        // TODO : 4. Centrar la aplicacion al abrir - DONE
        // TODO : 5. Marcar el formulario como FixedSingle - DONE
        // TODO : 6. Limitar edicion control ComboBox - DONE
        // TODO : 7. Parametrizar la propiedad TabIndex - DONE
        // TODO : 8. El evento Load del formulario debera llamar al metodo limpiar - PENDING
        // TODO : 9. lstOperaciones de ListBox debera mostrar todas las operaciones realizadas - PENDING
        // TODO : 10. Constructor por defecto - DONE
        // TODO : 11. Metodo Load - DONE
        // TODO : 12. Metodo Limpiar - DONE
        // TODO : 13. Metodo Operar - DONE
        // TODO : 14. Evento btnCerrar_Click - DONE
        // TODO : 15. Evento btnConvertirABinario_Click - PENDING
        // TODO : 16. Evento btnConvertirADecimal_Click - PENDING
        // TODO : 17. Evento btnLimpiar_Click - DONE
        // TODO : 18. Evento btnOperar_Click - DONE

        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
            char[] cmbDataSource = {'\0', '+', '-', '*', '/'};
            cmbOperador.DataSource = cmbDataSource;
        }

        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            cmbOperador.SelectedIndex = -1;
            lblResultado.ResetText();
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            return Calculadora.Operar(new Operando(numero1), new Operando(numero2), operador[0]);
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double num1Parseado;
            double num2Parseado;

            if(double.TryParse(txtNumero1.Text, out num1Parseado) && double.TryParse(txtNumero2.Text, out num2Parseado))
            {
                if(Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.SelectedItem.ToString()) != double.MinValue)
                {
                    lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.SelectedItem.ToString()).ToString();
                    if (cmbOperador.SelectedItem.ToString()[0] != '+' && cmbOperador.SelectedItem.ToString()[0] != '-' && cmbOperador.SelectedItem.ToString()[0] != '*' && cmbOperador.SelectedItem.ToString()[0] != '/')
                    {
                        lstOperaciones.Items.Add($"{txtNumero1.Text} + {txtNumero2.Text} = {lblResultado.Text}");
                    }
                    else
                    {
                        lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.SelectedItem} {txtNumero2.Text} = {lblResultado.Text}");
                    }
                }
                else
                {
                    MessageBox.Show("No es posible dividir un numero entre 0", "¡Error!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numericos validos", "¡Error!");
            } 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando aux = new Operando();
            if(lblResultado.Text != "")
            {
                lstOperaciones.Items.Add($"Binario: { aux.DecimalBinario(lblResultado.Text)}");
                lblResultado.Text = aux.DecimalBinario(lblResultado.Text);
            }
            else
            {
                MessageBox.Show("Por favor realice una operacion primero para asi poder convertir el resultado a binario", "¡Error!");
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando aux = new Operando();
            if(lblResultado.Text != "")
            {
                if(aux.BinarioDecimal(lblResultado.Text) != "Valor invalido")
                {
                    lstOperaciones.Items.Add($"Decimal: { aux.BinarioDecimal(lblResultado.Text)}");
                    lblResultado.Text = aux.BinarioDecimal(lblResultado.Text);
                }
                else
                {
                    MessageBox.Show("Por favor primero realice la conversion de su resultado a binario para poder convertirlo a decimal", "¡Error!");
                }
            }
            else
            {
                MessageBox.Show("Por favor realice una operacion primero para asi poder convertir el resultado a binario", "¡Error!");
            }
        }
    }
}
