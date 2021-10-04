using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador:User
    {
        public Administrador(string id, string pasword, string nombre, string apellido) : base(id, pasword, nombre, apellido)
        {

        }
    }
}
