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
    public partial class FormSwapPasword : Form
    {
        public Comercio petShop;
        public FormSwapPasword()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtPasword.Text == this.txtConfPasword.Text)
            {
                petShop.CambiarPaswordDeUsuarioLogeado = this.txtPasword.Text;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Las contraseñas no Coinciden!!!");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
