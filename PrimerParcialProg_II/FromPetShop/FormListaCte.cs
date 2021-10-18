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
    public partial class FormListaCte : Form
    {
        public Comercio petShop;
        public FormListaCte()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormListaCte_Load(object sender, EventArgs e)
        {
            this.dgvClientes.DataSource = petShop.Clientes;
        }
    }
}
