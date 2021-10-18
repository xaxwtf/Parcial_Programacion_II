using System;
using System.Collections.Generic;
using Entidades;

namespace TesteandoComercio
{
    class Program
    {
        static void Main(string[] args)
        {
            Comercio test = new Comercio("tester");
            List<Producto> clon= new List<Producto>();
            
            test.HarcodearDatos();
            if (test.LogearUsuario("juan23", "11111"))
            {
                Console.WriteLine("Logeado con exito");
                clon = Comercio.ClonarLista(test.Productos);
                Console.WriteLine("CLON!!!!!!!!!!");
                foreach (Producto aux in clon)
                {
                    aux.Cant_Disponible--;
                    Console.WriteLine(aux.ToString());
                    Console.WriteLine("{0}", aux.Cant_Disponible);

                }
                Console.WriteLine("CLON DE NUEVO!!!!!");
                foreach (Producto aux in clon)
                {
                    Console.WriteLine(aux.ToString());
                    Console.WriteLine("{0}", aux.Cant_Disponible);

                }
                Console.WriteLine("ORIGINAL!!!!!!");
                foreach (Producto aux in test.Productos)
                {
                    Console.WriteLine(aux.ToString());
                    Console.WriteLine("{0}", aux.Cant_Disponible);
                }
                clon.Clear();
                clon= clon = Comercio.ClonarLista(test.Productos);
                Console.WriteLine("CLON IGUALADO AL ORIGINAL");
                foreach (Producto aux in clon)
                {
                    Console.WriteLine(aux.ToString());
                    Console.WriteLine("{0}", aux.Cant_Disponible);

                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
