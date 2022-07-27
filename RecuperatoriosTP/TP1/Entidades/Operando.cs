using System;

namespace Entidades
{
    public class Operando
    {
        // TODO : 1. Asignación de atributos - DONE
        // TODO : 2. Constructor por defecto - DONE
        // TODO : 2_a. Constructor sobrecargado A - DONE
        // TODO : 2_b. Constructor sobrecargado B - DONE
        // TODO : 3. Propiedad Numero - DONE
        // TODO : 4. Metodo ValidarOperando - DONE
        // TODO : 5. Metodo EsBinario - DONE
        // TODO : 6. Metodo BinarioDecimal - DONE
        // TODO : 7. Metodo DecimalBinario - DONE
        // TODO : 7_a. Metodo DecimalBinario sobrecargado - DONE
        // TODO : 8. Sobrecarga operador + - DONE
        // TODO : 9. Sobrecarga operador - - DONE
        // TODO : 10. Sobrecarga operador * - DONE
        // TODO : 11. Sobrecarga operador / - DONE


        private double numero;

        public Operando() : this(0)
        {
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            this.numero = double.Parse(strNumero);
        }

        public string Numero
        {
            set { numero = ValidarOperando(value); }
        }

        public double ValidarOperando(string strNumero)
        {
            if (double.TryParse(strNumero, out double numeroParseado))
            {
                return numeroParseado;
            }
            else
            {
                return 0;
            }
        }

        private bool EsBinario(string binario)
        {
            foreach (char caracter in binario)
            {
                if (caracter != '0' && caracter != '1')
                {
                    return false;
                }
            }
            return true;
        }

        public string BinarioDecimal(string binario)
        {
            if (EsBinario(binario))
            {
                return Convert.ToInt32(binario, 2).ToString();
            }
            else
            {
                return "Valor invalido";
            }
        }

        public string DecimalBinario(string numero)
        {
            if (double.TryParse(numero, out double numeroParseado))
            {
                return DecimalBinario(numeroParseado);
            }
            else
            {
                return "Valor invalido";
            }
        }

        public string DecimalBinario(double numero)
        {
            return Convert.ToString(Convert.ToInt32(numero), 2);
        }

        

        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }

            return n1.numero / n2.numero;
        }
    }
}
