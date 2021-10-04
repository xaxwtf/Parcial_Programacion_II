using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromPetShop
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            tmrInactividad.Start();
        }

        private void FromLoginSuperUser_Load(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }

        private void tmrInactividad_Tick(object sender, EventArgs e)
        {
            tmrInactividad.Enabled = false;
            this.Dispose();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            tmrInactividad.Stop();
            tmrInactividad.Start();
        }
    }
}
