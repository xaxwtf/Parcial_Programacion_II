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
    public partial class FormGestionClientes : Form
    {
        public Comercio petShop;
        public FormGestionClientes()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnAltaCte_Click(object sender, EventArgs e)
        {
            FormCliente nuevo = new FormCliente();
            nuevo.petShop = petShop;
            nuevo.Show();
        }

        private void BtnMostrarCtes_Click(object sender, EventArgs e)
        {
            FormListaCte lista = new FormListaCte();
            lista.petShop = petShop;
            lista.Show();
        }

        private void BtnBajaCte_Click(object sender, EventArgs e)
        {
            FormBajaCliente cliente = new FormBajaCliente();
            cliente.petShop= petShop;
            cliente.Show();
        }
    }
}
