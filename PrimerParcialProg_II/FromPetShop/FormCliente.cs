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
    public partial class FormCliente : Form
    {
        public Comercio petShop;
        public FormCliente()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if(petShop.AltaCliente(this.txtNCteNombre.Text, this.txtNCteApellido.Text, this.txtNCteCuil.Text, double.Parse(this.txtEfectivo.Text)))
            {
                MessageBox.Show("Cliente Creado Con Exito!!!! ");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error, vuelva a intentarlo!!!!!!");
            }
        }
    }
}
