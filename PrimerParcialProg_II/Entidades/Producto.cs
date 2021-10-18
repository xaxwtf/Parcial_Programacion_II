using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        protected string descripcion;
        protected double precio;
        protected string marca;
        protected int cantDisponible;

        protected Producto(double precio, string marca,int cantDisponible):this(" ",precio,marca,cantDisponible)
        {

        }
        protected Producto(string descripcion,double precio, string marca, int cantDisponible)
        {
            this.descripcion = descripcion;
            this.precio = precio;
            this.marca = marca;
            this.cantDisponible = cantDisponible;
        }


        /// <summary>
        /// muestra todos los datos del Producto
        /// </summary>
        /// <returns></returns> una cadena de texto con todos los datos del producto
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.descripcion);
            return sb.ToString();
        }
       
        public virtual string  Descripcion { get { return this.descripcion; } }
        public string Marca { get { return this.marca; } }
        public int Cant_Disponible { get { return this.cantDisponible; } set { this.cantDisponible = value; } }
        public double Precio { get { return this.precio; } set { if (value > 0) { this.precio = value; } } }
        public abstract void AplicarImpuestos(); //borrar
        public abstract Producto GetProducto(int cuantos);
        public static bool operator ==(Producto a, Producto b)
        {
            bool r = false;
            if(a.Descripcion == b.Descripcion && a.Marca == b.Marca)
            {
                r = true;
            }
            return r;
        }
        public static bool operator !=(Producto a, Producto b)
        {
            return !(a == b);
        }
        public abstract Producto Reservar(int cuantos);
        public void Agregar(int cuantos)
        {
            if (cuantos > 0)
            {
                this.cantDisponible -= cuantos;
            }
        }
        public void Agregar(Producto p)
        {
                this.Agregar(p.Cant_Disponible);           
        }
        public abstract Producto Clone();
    }
}
  