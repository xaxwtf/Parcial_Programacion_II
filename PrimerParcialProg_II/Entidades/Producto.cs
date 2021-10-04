using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        protected string descripcion;
        protected double precio;
        public Producto(string descripcion, float precio)
        {
            this.descripcion = descripcion;
            this.precio = precio;
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0},{1}", this.descripcion, this.precio);
            return sb.ToString();
        }
        public double Precio { get { return this.precio; } }
        public string Descripcion { get { return this.descripcion; } set { this.descripcion = value; } }
    }
}
  