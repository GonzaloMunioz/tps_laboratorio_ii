using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Controlador<T> where T : class // TEMA 12 - TIPOS GENÉRICOS
    {
        List<T> listaDeElementos;

        public List<T> ListaDeElementos
        {
            get { return listaDeElementos; }
            set { listaDeElementos = value; }
        }

        public int CantidadDeElementos
        {
            get { return listaDeElementos.Count; }
        }

        public Controlador()
        {
            this.listaDeElementos = new List<T>();
        }

        /// <summary>
        /// Agrega a la lista los elementos contenidos dentro del controlador recibido como parámetro
        /// </summary>
        /// <param name="controladorAux"> Controlador que contiene los elementos a agregar </param>
        public void Concatenar(Controlador<T> controladorAux)
        {
            foreach (T cliente in controladorAux.ListaDeElementos)
            {
                _ = this + cliente;
            }
            
        }
        
        /// <summary>
        /// Añade el elemento a la lista del controlador, si es que, en principio, no lo encuentra
        /// </summary>
        /// <param name="c"> Controlador al que se agregará el elemento </param>
        /// <param name="elemento"> Elemento a agregar </param>
        /// <returns></returns>
        public static bool operator +(Controlador<T> c, T elemento)
        {
            if (c != elemento)
            {
                c.listaDeElementos.Add(elemento);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Recorre la lista del controlador, buscando una coincidencia utilizando el metodo Equals del elemento
        /// </summary>
        /// <param name="c"> Controlador que contendrá la lista </param>
        /// <param name="elemento"> Elemento a buscar </param>
        /// <returns></returns>
        public static bool operator ==(Controlador<T> c, T elemento)
        {
            foreach (T item in c.listaDeElementos)
            {
                if (item.Equals(elemento))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Retorna la negación del retorno del operador '=='
        /// </summary>
        /// <param name="c"> Controlador que contendrá la lista </param>
        /// <param name="elemento"> Elemento a buscar </param>
        /// <returns></returns>
        public static bool operator !=(Controlador<T> c, T elemento)
        {
            return !(c == elemento);
        }

        /// <summary>
        /// Retorna un string con la información de toda la lista del controlador
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T elemento in listaDeElementos)
            {
                sb.Append(elemento.ToString());
            }

            return sb.ToString();
        }
    }
}
