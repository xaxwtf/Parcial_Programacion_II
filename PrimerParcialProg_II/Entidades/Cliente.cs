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

        public Cliente(string nombre, string apellido, string cuil,double dinero)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cuil = cuil;
            this.disponibilidad = dinero;
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
        public bool LeAlcanzaElDinero(Producto producto)
        {
            bool r = false;
            if (producto != null)
            {
                if(producto.Precio <=this.disponibilidad)
                {
                    r = true;
                }
            }
            return r;
        }
        public static bool CuilIsValid(string cuil)
        {
            bool r = false;
            int aux;
            if(cuil.Length == 11 && int.TryParse(cuil,out aux))
            {
                r = true;
            }
            return r;
        }

        public static  bool operator == (Cliente a, Cliente b)
        {
            return a==b.cuil;
        }
        public static bool operator !=(Cliente a,Cliente b)
        {
            return !(a == b);
        }
        public static bool operator ==(Cliente a , string cuil)
        {
            bool r = false;
            if( a.cuil == cuil)
            {
                r = true;
            }
            return r;
        }
        public static bool operator !=(Cliente a, string cuil)
        {
            return !(a == cuil);
        }
        public static Cliente operator - (Cliente cte, double costo)
        {
            cte.Disponibilidad -= costo;
            return cte;
        }
    }
}
