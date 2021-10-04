using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string cuil;
        private double disponibilidad;

        public Cliente(string nombre, string apellido, string cuil)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cuil = cuil;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0},{1},{2}", this.apellido, this.nombre, this.cuil);
            return sb.ToString();
        }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Cuil { get { return this.cuil; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public double Disponibilidad { get { return this.disponibilidad; } set { this.disponibilidad = value; } }
        public bool Comprar(Producto producto)
        {
            bool r = false;
            if (producto != null)
            {
                if(producto.Precio <=this.disponibilidad)
                {
                    r = true;
                    this.disponibilidad = this.disponibilidad - producto.Precio;
                }
            }
            return r;
        }
        public bool ComprarVarios(List<Producto> productos)
        {
            bool r = false;
            double total=0;
            foreach(Producto aux in productos)
            {
                if (aux!=null)
                {
                    total = total + aux.Precio;
                }
            }
            if (disponibilidad >= total)
            {
                r = true;
                disponibilidad = disponibilidad - total;
            }
            return r;
        }
        public bool esCliente(string nombre, string apellido)
        {
            bool r = false;
            if (nombre == this.nombre && apellido == this.apellido)
            {
                r = true;
            }
            return r;
        }
    }
}
