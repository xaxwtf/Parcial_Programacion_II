using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FromPetShop
{
    
    public partial class FormBajaCliente : Form
    {
        protected Cliente cte;
        public Comercio petShop;
        private bool ok;
        public FormBajaCliente()
        {
            InitializeComponent();
            ok = false;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (ok)
            {
                this.petShop.BajaCliente(cte.Cuil);
                MessageBox.Show("Cliente Eliminado");
                this.Dispose();
            }
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormBajaCliente_Load(object sender, EventArgs e)
        {
            this.txtCuil.Text = cte.Cuil;
            this.txtNombre.Text = cte.Nombre;
            this.txtApellido.Text= cte.Apellido;
        }

        private void BtnBuscarDelete_Click(object sender, EventArgs e)
        {
            if (petShop.ValidarCliente(this.txtCuil.Text, cte))
            {
                this.txtCuil.ReadOnly = true;
                this.ok = true;
            }
            else
            {
                MessageBox.Show("el Cliente Ingresado no existe");
            }
        }
    }
}
