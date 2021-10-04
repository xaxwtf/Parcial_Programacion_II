using System;
using System.Text;

namespace Entidades
{
    public class User
    {
        protected string id;
        protected string pasword;
        protected string nombre;
        protected string apellido;
        protected Estado estadoUser;
        public User(string id, string pasword, string nombre, string apellido)
        {
            this.id = id;
            this.pasword = pasword;
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public string Id
        {
            get { return this.id; }
        }
        public string Pasword
        {
            set
            {
                if (value.Length > 7)
                {
                    this.pasword = value;
                }
            }
        }
        public Estado EstadoUser { get { return this.estadoUser; } set { this.estadoUser = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public static bool operator ==(User A, User B)
        {
            bool r = false;
            if(A.id== B.id)
            {
                r = true;
            }
            return r;
        }
        public static bool operator !=(User A,User B)
        {
            return !(A == B);
        }
        public bool ValidarContrasenia(string us, string pass)
        {
            bool r = false;
            if (us == this.id && pass == this.pasword)
            {
                r = true;
            }
            return r;
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            if(this is Empleado)
            {
                sb.AppendFormat("Empleado {0},{1},{2}", this.id, this.apellido, this.nombre);
            }
            else
            {
                sb.AppendFormat("Administrador {0},{1},{2}", this.id, this.apellido, this.nombre);
            }
            return sb.ToString();
        }
        public static bool operator ==(User a, string b)
        {
            bool r=false;
            if (a.id == b)
            {
                r = true;
            }
            return r;
        }
        public static bool operator !=(User a, string b)
        {
            return !(a == b);
        }
        public enum Estado { Activo,DeBaja }

    }
}
