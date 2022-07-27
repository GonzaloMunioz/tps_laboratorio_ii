using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {

        protected override ETamanio Tamanio
        {
            get { return ETamanio.Chico; }
        }

        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine("---------------------");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine(" + TAMAÑO: " + this.Tamanio + " +");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
