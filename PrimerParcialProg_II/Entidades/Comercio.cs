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
        private User usuarioLogeado;
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
        public List<Producto> Productos { get { return this.stock; } }
        public bool LogearUsuario(string iden, string contra)
        {
            bool r = false;
            if (SUsuario.EsSuperUsuario(iden, contra))
            {
                Comercio.estado = EstadoDeSesion.ConectadoSuperUsuario;
            }
            else
            {
                foreach (User aux in this.usuarios)
                {
                    if (aux.ValidarContrasenia(iden, contra))
                    {
                        if (aux is Administrador)
                        {
                            Comercio.estado = EstadoDeSesion.ConectadoAdministrador;
                        }
                        else
                        {
                            Comercio.estado = EstadoDeSesion.ConectadoEmpleado;
                        }
                        r = true;
                        usuarioLogeado = aux;
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
                if (aux == id)
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
            if (identificador != null && pasword != null && nombre != null && apellido != null && (estado == EstadoDeSesion.ConectadoAdministrador || estado == EstadoDeSesion.ConectadoSuperUsuario))
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
            if (identificador != null && pasword != null && nombre != null && apellido != null && (estado == EstadoDeSesion.ConectadoSuperUsuario))
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
            if (identificador != null)
            {
                //puedo agregar mas
                aux = (Empleado)BuscarUsuarioxID(identificador);
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
                r = this.BajaUsuario(indentificador);
            }
            return r;
        }
        private bool BajaUsuario(string idenficador)
        {
            bool r = false;
            User aux = this.BuscarUsuarioxID(idenficador);
            if (usuarios.Remove(aux))
            {
                r = true;
            }
            return r;
        }


        public Cliente ValidarCliente(string cuil) // supervisar!!
        {
            Cliente r=null;
            foreach (Cliente aux in this.clientes)
            {
                if (aux == cuil)
                {
                    r = aux;
                }
            }
            return r;
        }
        public  bool ExisteCliente(string cuil)
        {
            bool r = false;
            foreach (Cliente aux in this.clientes)
            {
                if (aux == cuil)
                {
                    r = true;
                    break;
                }
            }
            return r;
        }
        public bool ValidarCliente(string cuil, Cliente cliente)
        {
            bool r = false;
            foreach(Cliente aux in this.clientes)
            {
                if (aux == cuil)
                {
                    cliente = aux;
                    r = true;
                    break;
                }
            }
            return r;
        }
        public bool AltaCliente(string nombre, string apellido, string cuil, double efectivo)
        {
            bool r = false;
            if (this.IsCuitValidoYnoEstaRepetido(cuil))
            {
                Cliente nuevo = new Cliente(nombre, apellido, cuil, efectivo);
                this.clientes.Add(nuevo);
                r = true;
            }
            return r;
        }
        public bool BajaCliente(string cuil)
        {
            bool r = false;
            if (cuil != null)
            {
                Cliente aux = ValidarCliente(cuil);
                clientes.Remove(aux);
                r = true;
            }
            return r;
        }
        public void ModificarCliente(string cuil, string newName, string newlastName)
        {
            Cliente aux = ValidarCliente(cuil);
            aux.Nombre = newName;
            aux.Apellido = newlastName;
        }


        public bool ModificarFactura(int nroFactura, string observ)
        {
            bool r = false;
            Factura mod = null;
            foreach (Factura aux in this.registroVentas)
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
            foreach (Factura aux in this.registroVentas)
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


        public bool Vender(List<Producto> compras, Cliente cliente)
        {
            bool r = false;
            if (true)
            {
                Factura nuevo = null;
                if (estado == EstadoDeSesion.ConectadoSuperUsuario)
                {
                    nuevo = new Factura(compras, cliente, SUsuario.Id);
                }
                else if (estado != EstadoDeSesion.Desconectado)
                {
                    nuevo = new Factura(compras, cliente, usuarioLogeado.Id);
                }
                if (nuevo != null)
                {

                    if (cliente.Disponibilidad >= nuevo.PrecioTotal)
                    {
                        r = true;
                        registroVentas.Add(nuevo);
                        foreach (Producto aux in compras)
                        {
                            foreach( Producto pStock in this.stock)
                            {
                                if(aux == pStock)
                                {
                                    pStock.Cant_Disponible -= aux.Cant_Disponible;
                                }
                            }
                        }
                    }
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
                sb.AppendLine(aux.ToString());
            }
            return sb.ToString();
        }
        public string ListarClientes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Cliente aux in this.clientes)
            {
                sb.AppendLine(aux.Mostrar());
            }
            return sb.ToString();
        }
        public string listarUsuarios()
        {
            StringBuilder sb = new StringBuilder();
            foreach (User aux in this.usuarios)
            {
                sb.AppendLine(aux.ToString());
            }
            return sb.ToString();
        }
        private void HarcodearUsuarios()
        {
            Empleado em1 = new Empleado("juan23", "11111", "juan", "perez");
            usuarios.Add(em1);
            Administrador ad1 = new Administrador("carlos_21", "22222", "carlos", "guierrez");
            usuarios.Add(ad1);
        }
        private void HarcodearClientes()
        {
            Cliente c1 = new Cliente("sergio", "ramos", "20202020202", 500);
            this.clientes.Add(c1);
            Cliente c2 = new Cliente("jose", "sasdsdas", "21202020202", 500000);
            this.clientes.Add(c2);
            Cliente c3 = new Cliente("ramon", "ramos", "20202023203", 540000);
            this.clientes.Add(c1);
        }
        private void HarcodearProductos()
        {
            AlimentoGato p1 = new AlimentoGato(2000, "wiskas", 100, ETipo.adulto, 20);
            this.stock.Add(p1);
            Producto p2 = new AlimentoGato(5000, "ProPlan", 20, ETipo.cachorro, 30);
            this.stock.Add(p2);
            AlimentoPerro p3 = new AlimentoPerro(1500, "Purina", 200, ETipo.adulto, 30);
            this.stock.Add(p3);
            Alimento p4 = new AlimentoPerro(3300, "Proplan", 50, ETipo.cachorro, 20);
        }
        public void HarcodearDatos()
        {
            HarcodearUsuarios();
            HarcodearClientes();
            HarcodearProductos();
        }
        public EstadoDeSesion Conectado
        {
            get
            {
                return estado;
            }
        }
        public static void Desconectar()
        {
            estado = EstadoDeSesion.Desconectado;
        }
        public string NombreComercio { get { return this.nombre; } }
        public string UsuarioLogeado { get { return this.usuarioLogeado.Id; } }

        public static Comercio operator +(Comercio com, Factura fac)
        {
            com.registroVentas.Add(fac);
            return com;
        }
        public static double CalcularTotal(List<Producto> lista)
        {
            double total = 0;
            foreach (Producto aux in lista)
            {
                total += aux.Precio;
            }    
            return total;
        }
        public bool ComprobarExistencias(List<Producto> ordCompra)
        {
            bool r = true;
            foreach(Producto pSolicitado in ordCompra)
            {
                foreach(Producto aux in this.stock)
                {
                    if (pSolicitado.Cant_Disponible < aux.Cant_Disponible)
                    {
                        r=false;
                    }
                }
            }
            return r;
        }
        public static void SumarListas(List<Producto> a, List<Producto> b)
        {
            foreach(Producto bAux in b)
            {
                foreach(Producto aAux in a)
                {
                    if (bAux.Descripcion == aAux.Descripcion && bAux.Marca== aAux.Marca)
                    {
                        aAux.Agregar(bAux);
                    }
                }
            }
        }
        public static List<Producto> ClonarLista(List<Producto> ListAClonar)
        {
            List<Producto> copia = new List<Producto>();
            foreach(Producto aux in ListAClonar)
            {
                copia.Add(aux.Clone());
            }
            return copia;
        }
        public bool IsCuitValidoYnoEstaRepetido(string cuil)
        {
            bool r = false;
            if(Cliente.CuilIsValid(cuil)&& this.ExisteCliente(cuil))
            {
                r = true;
            }
            return r;
        }
        public List<Cliente> Clientes { get { return this.clientes; } }
        public string CambiarPaswordDeUsuarioLogeado { 
            set {
                if (true)
                {
                    this.usuarioLogeado.Pasword = value;
                }
                
            }
        }

    }
    public enum EstadoDeSesion { ConectadoSuperUsuario, ConectadoAdministrador, ConectadoEmpleado, Desconectado }
}
