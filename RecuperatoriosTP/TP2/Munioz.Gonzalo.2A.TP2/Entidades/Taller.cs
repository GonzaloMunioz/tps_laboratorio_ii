using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    sealed public class Taller
    {
        public enum ETipo
        {
            Ciclomotor, 
            Sedan, 
            SUV, 
            Todos
        }

        List<Vehiculo> vehiculos;
        int espacioDisponible;
        
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Taller(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }

        /// <summary>
        /// Listo el estacionamento y cada uno de los vehículos dentro
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Taller.Listar(this, ETipo.Todos);
        }

        /// <summary>
        /// Muestra los datos del taller y de todos los vehículos que contiene si son del tipo que se especificó
        /// </summary>
        /// <param name="taller"> Elemento a mostrar </param>
        /// <param name="ETipo"> Tipo del elemento a mostrar </param>
        /// <returns></returns>
        public static string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("");
            if (!(taller.vehiculos is null))
            {
                sb.AppendFormat("Hay {0} lugares ocupados de {1} disponibles\n\n", taller.vehiculos.Count, taller.espacioDisponible);
                foreach (Vehiculo v in taller.vehiculos)
                {
                    switch (tipo)
                    {
                        case ETipo.Ciclomotor:
                            if (v is Ciclomotor)
                            {
                                sb.AppendLine(v.Mostrar());
                            }
                            break;
                        case ETipo.SUV:
                            if (v is Suv)
                            {
                                sb.AppendLine(v.Mostrar());
                            }
                            break;
                        case ETipo.Sedan:
                            if (v is Sedan)
                            {
                                sb.AppendLine(v.Mostrar());
                            }
                            break;
                        default:
                            sb.AppendLine(v.Mostrar());
                            break;
                    }
                }

            }

            return sb.ToString();
        }

        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller"> Objeto donde se agregará el elemento </param>
        /// <param name="vehiculo"> Elemento a agregar </param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {

            if (!(taller.vehiculos is null) && taller.espacioDisponible > taller.vehiculos.Count)
            {
                foreach (Vehiculo v in taller.vehiculos)
                {
                    if (v == vehiculo)
                        return taller;
                }
                taller.vehiculos.Add(vehiculo);
            }
            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller"> Objeto de donde se quitará el elemento </param>
        /// <param name="vehiculo"> Elemento a quitar </param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {

            if (!(taller.vehiculos is null))
            {
                foreach (Vehiculo v in taller.vehiculos)
                {
                    if (v == vehiculo)
                    {
                        taller.vehiculos.Remove(v);
                        return taller;
                    }
                }
            }
            return taller;
        }
    }
}
