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
    public partial class Form_Menu_Empleado : Form
    {
        public Comercio petShop;
        public Form_Menu_Empleado()
        {
            InitializeComponent();
        }

        protected void Form_Menu_Empleado_Load(object sender, EventArgs e)
        {
            this.txtIdUsuario.Text = this.petShop.UsuarioLogeado;
            this.picImageUser.BackgroundImage= Image.FromFile("empleado.jpg");
            this.picImageUser.BackgroundImageLayout=ImageLayout.Stretch;
        }

        protected void BtnVentas_Click(object sender, EventArgs e)
        {
            FormSelecionCliente seleccion = new FormSelecionCliente();
            seleccion.petShop = this.petShop;
            seleccion.Show();
        }

        protected void BtnSwapPasword_Click(object sender, EventArgs e)
        {
            FormSwapPasword swap = new FormSwapPasword();
            swap.petShop = this.petShop;
            swap.Show();
        }

        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
