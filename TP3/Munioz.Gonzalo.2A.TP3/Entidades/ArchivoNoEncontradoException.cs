using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivoNoEncontradoException : Exception // TEMA 10 - EXCEPCIONES
    {
        public ArchivoNoEncontradoException(string mensaje) : this(mensaje, null)
        {
        }

        public ArchivoNoEncontradoException(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }
    }
}
