using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        int id;
        static int ultimoID = 1000;
        DateTime turno;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int UltimoID
        {
            get { return ultimoID; }
            set { ultimoID = value; }
        }

        public DateTime Turno
        {
            get { return turno; }
            set { turno = value; }
        }

        public Cliente()
        {

        }

        public Cliente(DateTime turno, string nombre, string apellido, string dni, string direccion) : base(nombre, apellido, dni, direccion)
        {
            id = ultimoID;
            ultimoID++;
            this.turno = turno;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($" - ID: {id}");
            sb.Append($"{base.Mostrar()}");
            sb.AppendLine($" - Turno: {turno.ToShortDateString()}\n");

            return sb.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public override bool Equals(object obj)
        {
            return this == (obj as Cliente);
        }

        public static explicit operator string(Cliente cliente)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($" • Cliente: {cliente.NombreCompleto}");
            sb.AppendLine($" • Turno: {cliente.turno.ToShortDateString()}");

            return sb.ToString();
        }
    }
}
