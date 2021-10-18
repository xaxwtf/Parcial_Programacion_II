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
    public partial class FormCreacionOrdenCompra : Form
    {
        public Comercio petAux;
        public Cliente cte;
        public List<Producto> ordenCompra,listaAuxData;
        private Producto aux;
        public FormCreacionOrdenCompra()
        {
            InitializeComponent();
            ordenCompra = new List<Producto>();
            listaAuxData = new List<Producto>();
            

        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            listaAuxData = Comercio.ClonarLista(petAux.Productos);
            if (listaAuxData == petAux.Productos)
            {
                MessageBox.Show("son la misma dirreccion");
            }
            this.dgvStock.DataSource = null;
            this.dgvStock.DataSource = listaAuxData;
            this.dgvOrdenCompra.DataSource = ordenCompra;
            this.txtNombreCte.Text = cte.Nombre;
            this.txtApellidoCte.Text = cte.Apellido;
            this.txtCuilCte.Text = cte.Cuil;
            this.txtSaldoCliente.Text= cte.Disponibilidad.ToString();

        }

        private void BtnAnadir_Click(object sender, EventArgs e)
        {
            aux = (Producto)dgvStock.CurrentRow.DataBoundItem;
            ordenCompra.Add(aux.Reservar(1));
            this.dgvOrdenCompra.DataSource = null;
            this.dgvOrdenCompra.DataSource = ordenCompra;
            this.dgvStock.DataSource = null;
            this.dgvStock.DataSource = listaAuxData;
            this.txtPrecioTotal.Text = Comercio.CalcularTotal(ordenCompra).ToString();
        }

        private void BtnRealizarPedido_Click(object sender, EventArgs e)
        {
            if (this.ordenCompra.Count > 0)
            {
                if (cte.Disponibilidad >= double.Parse(this.txtPrecioTotal.Text))
                {
                    petAux.Vender(ordenCompra, cte);
                }
                else
                {
                    this.txtPrecioTotal.ForeColor = Color.Red;
                    MessageBox.Show("Saldo Insuficiente..");
                }
            }
            else
            {
                MessageBox.Show("El Orden de Compras Esta Vacio");
            }
            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.dgvStock.DataSource = null;
            listaAuxData.Clear();
            listaAuxData = Comercio.ClonarLista(petAux.Productos);
            this.dgvStock.DataSource = listaAuxData;

            this.txtPrecioTotal.ForeColor = Color.Black;
            this.dgvOrdenCompra.DataSource = null;
            this.ordenCompra.Clear();
            this.txtPrecioTotal.Text = Comercio.CalcularTotal(ordenCompra).ToString();
        }
    }
}
