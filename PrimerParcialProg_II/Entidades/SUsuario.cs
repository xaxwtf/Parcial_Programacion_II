using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class SUsuario
    {
        private static string id;
        private static string pasword;
        static SUsuario()
        {
            id = "admin";
            pasword = "admin";
        }
        public static bool EsSuperUsuario(string identif , string pass)
        {
            bool r = false;
            if(id==identif&& pass == pasword)
            {
                r = true;
            }
            return r;
        }
        public static string Id { get { return id; } }
    }
}
