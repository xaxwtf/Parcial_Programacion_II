using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comercio
    {
        private string nombre;
        private List<User> usuarios;
        private List<Producto> stock;
        private List<Factura> registroVentas;
        private List<Cliente> clientes;
        private static EstadoDeSesion estado;
        static Comercio()
        {
            Comercio.estado = EstadoDeSesion.Desconectado;
        }
        public Comercio()
        {
            usuarios = new List<User>();
            stock = new List<Producto>();
            registroVentas = new List<Factura>();
            clientes = new List<Cliente>();
            nombre = "N/A";
        }
        public Comercio(string name) : this()
        {
            nombre = name;
        }
        public Comercio(string name, List<Producto> productos, List<User> users) : this(name)
        {
            this.usuarios = users;
            this.stock = productos;
        }
        public User LogearUsuario(string iden, string contra)
        {
            User r = null;
            if(SUsuario.EsSuperUsuario(iden,contra))
            {
                Comercio.estado = EstadoDeSesion.ConectadoSuperUsuario;
            }
            else
            {
                foreach (User aux in this.usuarios)
                {
                    if (aux.ValidarContrasenia(iden, contra))
                    {
                        if(aux is Administrador)
                        {
                            Comercio.estado = EstadoDeSesion.ConectadoAdministrador;
                        }
                        else
                        {
                            Comercio.estado = EstadoDeSesion.ConectadoEmpleado;
                        }
                        r = aux;
                    }
                }
            }
            
            return r;
        }


        private User BuscarUsuarioxID(string id)
        {
            User r = null;
            foreach (User aux in this.usuarios)
            {
                if (aux==id)
                {
                    r = aux;
                }
            }
            return r;
        }
        public bool AltaEmpleado(string identificador, string pasword, string nombre, string apellido)
        {
            bool r = false;
            Empleado nuevo;
            if (identificador!=null && pasword !=null && nombre!=null&&apellido!=null &&(estado==EstadoDeSesion.ConectadoAdministrador||estado==EstadoDeSesion.ConectadoSuperUsuario))
            {
                nuevo = new Empleado(identificador, pasword, nombre, apellido);
                if (true)
                {
                    this.usuarios.Add(nuevo);
                    r = true;
                }
            }
            return r;
        }
        public bool AltaAdministrador(string identificador, string pasword, string nombre, string apellido)
        {
            bool r = false;
            Administrador nuevo;
            if (identificador!=null&& pasword!=null && nombre!=null && apellido!=null && (estado == EstadoDeSesion.ConectadoSuperUsuario))
            {
                nuevo = new Administrador(identificador, pasword, nombre, apellido);
                if (true)
                {
                    this.usuarios.Add(nuevo);
                    r = true;
                }
            }
            return r;
        }
        public bool ModEmpleado(string identificador, string newPasword)
        {
            bool r = false;
            Empleado aux;
            if(identificador!=null)
            {
                //puedo agregar mas
                aux =(Empleado)BuscarUsuarioxID(identificador);
                aux.Pasword = newPasword;
                r = true;
            }
            return r;
        }
        public bool ModAdministrador(string identificador, string newPasword)
        {
            bool r = false;
            Empleado aux;
            if (identificador != null && (estado == EstadoDeSesion.ConectadoAdministrador || estado == EstadoDeSesion.ConectadoSuperUsuario))
            {
                //puedo agregar mas
                aux = (Empleado)BuscarUsuarioxID(identificador);
                aux.Pasword = newPasword;
                r = true;
            }
            return r;
        }
        public bool BajaEmpleado(string indetificador)
        {
            bool r = false;
            if (estado == EstadoDeSesion.ConectadoAdministrador)
            {
                r = this.BajaUsuario(indetificador);
            }
            return r;
        }
        public bool BajaAdministrador(string indentificador)
        {
            bool r = false;
            if (estado == EstadoDeSesion.ConectadoAdministrador)
            {
                r=this.BajaUsuario(indentificador);
            }
            return r;
        }
        private bool BajaUsuario(string idenficador)
        {
            bool r = false;
            User aux= this.BuscarUsuarioxID(idenficador);
            if (usuarios.Remove(aux))
            {
                r = true;
            }
            return r;
        }


        public Cliente ValidarCliente(string cuil)
        {
            Cliente r = null;
            foreach(Cliente aux in this.clientes)
            {
                if (aux.Cuil == cuil)
                {
                    r = aux;
                }
            }
            return r;
        }
        public bool AltaCliente(string nombre, string apellido, string cuil)
        {
            bool r = false;
            Cliente nuevo = new Cliente(nombre, apellido, cuil);
            if (nuevo != null)
            {
                this.clientes.Add(nuevo);
                r = true;
            }
            return r;
        }
        public bool BajaCliente(string cuil)
        {
            bool r = false;
            Cliente aux = ValidarCliente(cuil);
            if (aux != null)
            {
                clientes.Remove(aux);
                r = true;
            }
            return r;
        }
        public bool ModificarCliente(string cuil, string newName, string newlastName)
        {
            bool r = false;
            Cliente aux = ValidarCliente(cuil);
            if (aux != null)
            {
                aux.Nombre = newName;
                aux.Apellido = newlastName;
                r = true;
            }
            return r;
        }


        public bool ModificarFactura(int nroFactura, string observ)
        {
            bool r = false;
            Factura mod=null;
            foreach(Factura aux in this.registroVentas)
            {
                if (aux == nroFactura)
                {
                    mod = aux;
                    break;
                }
            }
            if (mod != null)
            {
                mod.Observaciones = observ;
                r = true;
            }
            return r;
        }
        private bool EliminarFactura(int nroFactura)
        {
            bool r = false;
            foreach(Factura aux in this.registroVentas)
            {
                if (aux == nroFactura)
                {
                    this.registroVentas.Remove(aux);
                    r = true;
                    break;
                }
            }
            return r;
        }


        public bool Vender(User vendedor, List<Producto> compras, Cliente cliente)
        {
            bool r = false;
            if (true)
            {
                Factura nuevo = new Factura(compras, vendedor);

                if (nuevo != null)
                {
                    foreach (Producto aux in compras)
                    {
                        this.stock.Remove(aux);
                    }
                    cliente.ComprarVarios(compras);
                    this.registroVentas.Add(nuevo);
                    r = true;
                }
            }
            return r;
        }
        public string listarStock()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Stock");
            foreach (Producto aux in this.stock)
            {
                sb.AppendLine(aux.Mostrar());
            }
            return sb.ToString();
        }
        public string ListarClientes()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Cliente aux in this.clientes)
            {
                sb.AppendLine(aux.Mostrar());
            }
            return sb.ToString();
        }
        public string listarUsuarios()
        {
            StringBuilder sb = new StringBuilder();
            foreach(User aux in this.usuarios)
            {
                sb.AppendLine(aux.ToString());
            }
            return sb.ToString();
        }
        public void HarcodearDatos()
        {
            Empleado em1 = new Empleado("juan23", "11111", "juan", "perez");
            usuarios.Add(em1);
            Administrador ad1 = new Administrador("carlos_21", "22222", "carlos", "guierrez");
            usuarios.Add(ad1);
            Producto p1 = new Producto("comida", 100);
            stock.Add(p1);
            Producto p2 = new Producto("correa", 200);
            stock.Add(p2);
            Producto p3 = new Producto("pollo de goma", 50);
            stock.Add(p3);
            Producto p4 = new Producto("hueso de goma", 60);
            stock.Add(p4);
            Producto p5 = new Producto("galletas", 120);
            stock.Add(p5);
            Cliente c1 = new Cliente("ariel", "suarez", "11111111111");
        }
        public EstadoDeSesion Conectado
        {
            get
            {
                return estado;
            }
        }
        public  void Desconectar()
        {
            estado = EstadoDeSesion.Desconectado;
        }
    }
    
}
public enum EstadoDeSesion {ConectadoSuperUsuario,ConectadoAdministrador,ConectadoEmpleado,Desconectado}
