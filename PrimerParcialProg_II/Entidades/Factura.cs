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
        private string idVendedor; // no se deberia modificar por nadie
        private Cliente comprador;
        static Factura()
        {
            nroFacturaAnterior = 0;
        }
        private Factura()
        {
            this.productos = new List<Producto>();
        }
        public Factura( List<Producto> productos, Cliente comprador, string idVendedor):this()
        {
            this.idVendedor = idVendedor;
            this.productos = productos;
            this.comprador = comprador;
            this.nroFactura = nroFacturaAnterior + 1;
            nroFacturaAnterior = nroFacturaAnterior++;
            this.CalcularTotalFacturado();
        }
        public int NroFactura { get { return this.nroFactura; } }
        public List<Producto> Productos { get { return this.productos; } }
        private void CalcularTotalFacturado()
        {
            double total=0;
            foreach(Producto aux in this.productos)
            {
                total = total + (aux.Precio *aux.Cant_Disponible);
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
        public Cliente Comprador
        {
            get { return this.comprador; }
        }
        public string IdVendedor { get { return this.idVendedor; } }
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
        public static bool operator ==(Factura fac, Producto produc)
        {
            bool r = false;
            foreach(Producto aux in fac.productos)
            {
                if (aux == produc)
                {
                    r = true;
                    break;
                }
            }
            return r;
        }
        public static bool operator !=(Factura fac, Producto producto)
        {
            return !(fac == producto);
        }
    }
}
