using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado:User
    {
        public Empleado(string id, string pasword, string nombre, string apellido) : base(id,pasword,nombre,apellido)
        {

        }

    }
}
