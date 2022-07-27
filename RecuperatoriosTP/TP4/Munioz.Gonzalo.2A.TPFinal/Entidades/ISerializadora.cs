using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ISerializadora<T> // TEMA 13 - INTERFACES
    {
        /// <summary>
        /// Serializa y guarda en un archivo cualquier objeto
        /// </summary>
        /// <param name="elemento"> Elemento a serializar </param>
        /// <param name="nombreArchivo"> Nombre del archivo a escribir </param>
        public void Serializar(T elemento, string nombreArchivo);

        /// <summary>
        /// Deserializa un archivo y almacena la información retribuida en un objeto del mismo tipo
        /// </summary>
        /// <param name="nombreArchivo"> Nombre del archivo a leer </param>
        /// <returns> Retorna el objeto deserializado </returns>
        public T Deserializar(string nombreArchivo);
    }
}
