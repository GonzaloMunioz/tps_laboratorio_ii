using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        string nombre;
        string apellido;
        string dni;
        string direccion;

        public string NombreCompleto
        {
            get { return nombre + " " + apellido; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public Persona()
        {

        }

        protected Persona(string nombre, string apellido, string dni, string direccion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($" - Cliente: {nombre} {apellido}");
            sb.AppendLine($" - D.N.I.: {dni}");
            sb.AppendLine($" - Dirección: {direccion}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public static bool operator ==(Persona personaUno, Persona personaDos)
        {
            return personaUno.dni == personaDos.dni;
        }

        public static bool operator !=(Persona personaUno, Persona personaDos)
        {
            return !(personaUno == personaDos);
        }
    }
}
