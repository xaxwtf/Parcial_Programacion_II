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
    public partial class FormSelecionCliente : Form
    {
        public Comercio petShop;
        public Cliente cte;
        public FormSelecionCliente()
        {
            InitializeComponent();
        }

        protected virtual void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (petShop.ValidarCliente(this.txtCuil.Text,cte))
            {
                cte=petShop.ValidarCliente(this.txtCuil.Text);
                FormCreacionOrdenCompra OrdenCompra = new FormCreacionOrdenCompra();
                OrdenCompra.petAux = this.petShop;
                OrdenCompra.cte = cte;
                OrdenCompra.Show();
            }
            else
            {
                MessageBox.Show("El Cliente no existe");
                this.Dispose();
            }
        }
    }
}
