using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Alimento:Producto
    {
        protected ETipo tipo;
        protected double kilos;
        public Alimento(string descripcion,double precio, string marca,int cantDisponible, ETipo tipo, double kg) : base(descripcion, precio, marca, cantDisponible)
        {
            this.tipo = tipo;
            this.kilos = kg;
        }
        public ETipo Tipo { get { return this.tipo; } }
        public double Peso {  get { return this.kilos; } }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            switch (this.tipo)
            {
                case ETipo.adulto:
                    sb.Append(" Adultos ");
                    break;
                case ETipo.cachorro:
                    sb.Append(" Cachorros ");
                    break;
            }
            sb.AppendFormat(" de {0}Kg", this.kilos);
            return sb.ToString();
        }
        public override void AplicarImpuestos() /// borrar
        {
            throw new NotImplementedException();
        }
        public override string Descripcion => this.Mostrar();

    }
    public enum ETipo{adulto,cachorro}
}
