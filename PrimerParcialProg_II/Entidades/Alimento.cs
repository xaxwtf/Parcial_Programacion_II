using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alimento:Producto
    {
        protected ETipo tipo;
        public Alimento(string descripcion, double precio):base(descripcion,precio)
        {

        }
        public Alimento(string descripcion, double precio, ETipo tipo): this(descripcion,precio)
        {
            this.tipo = tipo;
        }
    }
    public enum ETipo{gato,perro,conejo}
}
