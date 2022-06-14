using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        string marca;
        float precio;
        float precioVenta;
        string descripcion;
        int cantidad;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public float PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = precio * 1.4F; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public Producto()
        {

        }

        public Producto(string marca, float precio, string descripcion)
        {
            this.marca = marca;
            this.precio = precio;
            this.precioVenta = precio * 1.4F;
            this.descripcion = descripcion;
            this.cantidad = 0;
        }

        public static bool operator ==(Producto productoUno, Producto productoDos)
        {
            if (productoUno.marca.ToLower() == productoDos.marca.ToLower() && productoUno.descripcion.ToLower() == productoDos.descripcion.ToLower())
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Producto productoUno, Producto productoDos)
        {
            return !(productoUno == productoDos);
        }


        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($" • Marca: {marca}");
            sb.AppendLine($" • Costo: {precio}");
            sb.AppendLine($" • Precio de venta: {precioVenta}");
            sb.AppendLine($" • Descripción: {descripcion}");
            sb.AppendLine($" • Cantidad en stock: {cantidad}\n");

            return sb.ToString();
        }

        public override string ToString()
        {
            return Mostrar(); 
        }

        public override bool Equals(object obj)
        {
            return this == (obj as Producto);
        }
    }
}
