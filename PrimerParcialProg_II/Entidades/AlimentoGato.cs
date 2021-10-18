using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AlimentoGato:Alimento
    {
        private static double iva;
        static AlimentoGato()
        {
            iva= 21/100;
        }
       
        public AlimentoGato(double precio,string marca, int cantDisp, ETipo tipo, double kg) : base("Alimento Balanceado para Gatos", precio, marca, cantDisp,tipo,kg)
        {

        }
        public override void AplicarImpuestos()
        {
            this.precio = this.precio + (this.precio * iva);
        }
        public static double Iva { 
            set {
                if (value > 0)
                {
                    iva = (value/100);
                }
            } 
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}", base.Mostrar());
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        public override Producto GetProducto(int cuantos)
        {
            return this - cuantos;
        }
        public override Producto Reservar(int cuantos)
        {
            AlimentoGato nuevo = (AlimentoGato)this.Clone();
            nuevo.cantDisponible = cuantos;
            this.cantDisponible = this.cantDisponible-cuantos;
            return nuevo;
        }
        public override Producto Clone()
        {
            return new AlimentoGato(this.precio,this.marca,this.cantDisponible,this.tipo,this.kilos);
        }
        public static AlimentoGato operator +(AlimentoGato a, AlimentoGato b)
        {
            if (a == b)
            {
                a.cantDisponible += b.cantDisponible;
            }
            return a;
        }
        public static AlimentoGato operator -(AlimentoGato a, AlimentoGato b)
        {
            if (a == b)
            {
                a.cantDisponible -= b.cantDisponible;
            }
            return a;
        }
        public static AlimentoGato operator -(AlimentoGato p, int cantidad)
        {
            AlimentoGato np = new(p.precio, p.marca, cantidad, p.tipo, p.kilos);
            if (np != null)
            {
                p.cantDisponible -= cantidad;
            }
            return np;
        }
    }
}
