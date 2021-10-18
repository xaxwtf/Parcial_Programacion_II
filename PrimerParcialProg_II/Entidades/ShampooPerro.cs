using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ShampooPerro:Producto
    {
        double mililitros;
        public ShampooPerro(double precio, string marca,int cantDisp,double ml):base("SHAMPOO para Perros",precio,marca,cantDisp)
        {
            this.mililitros = ml;
        }
        public override void AplicarImpuestos()
        {
            throw new NotImplementedException();
        }
        public double Mililitros { get { return this.mililitros; } }
        public override Producto GetProducto(int cuantos)
        {
            throw new NotImplementedException();
        }
        public override Producto Reservar(int cuantos)
        {
            ShampooPerro nuevo = (ShampooPerro)this.Clone();
            nuevo.cantDisponible = cuantos;
            this.cantDisponible -= cuantos;
            return nuevo;
        }
        public override Producto Clone()
        {
            return new ShampooPerro(this.precio,this.marca,this.cantDisponible,this.mililitros);
        }
    }
}
