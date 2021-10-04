using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        private int nroFactura; // no se deberia modificar por nadie
        private List<Producto> productos;
        private static int nroFacturaAnterior;
        private double precioTotal;// solo se deberia ver se calcula solo
        private string observaciones; 
        private User vendedor; // no se deberia modificar por nadie
        static Factura()
        {
            nroFacturaAnterior = 0;
        }
        private Factura()
        {
            this.productos = new List<Producto>();
        }
        public Factura(List<Producto> productos) : this()
        {
            this.productos = productos;
            this.nroFactura = nroFacturaAnterior + 1;
            nroFacturaAnterior = nroFacturaAnterior++;
            this.CalcularTotalFacturado();
        }
        public Factura( List<Producto> productos, User usuario):this(productos)
        {
            this.vendedor = usuario;
        }
        public int NroFactura { get { return this.nroFactura; } }
        public List<Producto> Productos { get { return this.productos; } }
        private void CalcularTotalFacturado()
        {
            double total=0;
            foreach(Producto aux in this.productos)
            {
                total = total + aux.Precio;
            }
            this.precioTotal = total;
        }

        public double PrecioTotal
        {
            get
            {
                return this.precioTotal;
            }
        }
        public string Observaciones { 
            get 
            { 
                return this.observaciones; 
            } 
            set 
            {
                this.observaciones = value; 
            } 
        }
        public User Vendedor
        {
            get { return this.vendedor; }
        }
        public static bool operator ==(Factura a, int b)
        {
            bool r = false;
            if(a.nroFactura == b)
            {
                r = true;
            }
            return r;
        }
        public static bool operator !=(Factura a, int b)
        {
            return !(a == b);
        }
    }
}
