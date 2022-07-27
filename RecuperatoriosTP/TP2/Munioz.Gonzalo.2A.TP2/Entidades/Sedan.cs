using System;
using System.Text;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo 
        { 
            CuatroPuertas, 
            CincoPuertas 
        }

        ETipo tipo;

        protected override ETamanio Tamanio
        {
            get { return ETamanio.Mediano; }
        }

        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
            this.tipo = ETipo.CuatroPuertas;
        }

        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : this(marca, chasis, color)
        {
            this.tipo = tipo;
        }



        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine("---------------------");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($" + TAMAÑO : {this.Tamanio} +");
            sb.AppendLine(" + TIPO : " + this.tipo + " +");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
