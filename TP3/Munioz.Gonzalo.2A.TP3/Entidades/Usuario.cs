using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario 
    {
        string usuario;
        string contrasenia;
        string nombreCompleto;
        string correoElectronico;
        DateTime fechaDeNacimiento;

        public Usuario(string usuario, string contrasenia, string nombreCompleto, string correoElectronico, DateTime fechaDeNacimiento) 
        {
            this.usuario = usuario;
            this.contrasenia = contrasenia;
            this.nombreCompleto = nombreCompleto;
            this.correoElectronico = correoElectronico;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public static bool operator ==(Usuario usuario1, Usuario usuario2)
        {
            if (usuario1.usuario == usuario2.usuario && usuario1.contrasenia == usuario2.contrasenia)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Usuario usuario1, Usuario usuario2)
        {
            return !(usuario1 == usuario2);
        }
    }
}
