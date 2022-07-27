using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class StringExtension // TEMA 21 - MÉTODOS DE EXTENSIÓN
    { 
        /// <summary> 
        /// Recorre un string validando que cada caracter sea de tipo numérico, y tenga una longitud de 8 caracteres
        /// </summary>
        /// <param name="dni"> Cadena a validar </param>
        /// <returns></returns>
        public static bool ValidarDNI(this string dni)
        {
            if(dni is null)
            {
                return false;
            }

            if (dni.Length == 8)
            {
                foreach (char caracter in dni)
                {
                    if (!char.IsDigit(caracter))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }
    }
}
