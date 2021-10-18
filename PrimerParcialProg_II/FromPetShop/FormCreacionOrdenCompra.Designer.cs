
namespace FromPetShop
{
    partial class FormCreacionOrdenCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAnadir = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.dgvOrdenCompra = new System.Windows.Forms.DataGridView();
            this.BtnRealizarPedido = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreCte = new System.Windows.Forms.TextBox();
            this.txtApellidoCte = new System.Windows.Forms.TextBox();
            this.txtCuilCte = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.txtSaldoCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAnadir
            // 
            this.BtnAnadir.Location = new System.Drawing.Point(38, 234);
            this.BtnAnadir.Name = "BtnAnadir";
            this.BtnAnadir.Size = new System.Drawing.Size(138, 23);
            this.BtnAnadir.TabIndex = 1;
            this.BtnAnadir.Text = "Añadir";
            this.BtnAnadir.UseVisualStyleBackColor = true;
            this.BtnAnadir.Click += new System.EventHandler(this.BtnAnadir_Click);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToResizeColumns = false;
            this.dgvStock.AllowUserToResizeRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvStock.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStock.Location = new System.Drawing.Point(12, 45);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(2, 6, 4, 4);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvStock.RowTemplate.Height = 25;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.ShowEditingIcon = false;
            this.dgvStock.Size = new System.Drawing.Size(568, 173);
            this.dgvStock.TabIndex = 3;
            this.dgvStock.UseWaitCursor = true;
            // 
            // dgvOrdenCompra
            // 
            this.dgvOrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenCompra.Location = new System.Drawing.Point(12, 421);
            this.dgvOrdenCompra.Name = "dgvOrdenCompra";
            this.dgvOrdenCompra.RowTemplate.Height = 25;
            this.dgvOrdenCompra.Size = new System.Drawing.Size(568, 97);
            this.dgvOrdenCompra.TabIndex = 4;
            // 
            // BtnRealizarPedido
            // 
            this.BtnRealizarPedido.Location = new System.Drawing.Point(99, 553);
            this.BtnRealizarPedido.Name = "BtnRealizarPedido";
            this.BtnRealizarPedido.Size = new System.Drawing.Size(138, 23);
            this.BtnRealizarPedido.TabIndex = 5;
            this.BtnRealizarPedido.Text = "Realizar Pedido";
            this.BtnRealizarPedido.UseVisualStyleBackColor = true;
            this.BtnRealizarPedido.Click += new System.EventHandler(this.BtnRealizarPedido_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(99, 524);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(138, 23);
            this.BtnLimpiar.TabIndex = 6;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "ORDEN DE COMPRA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "CLIENTE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cuil:";
            // 
            // txtNombreCte
            // 
            this.txtNombreCte.Location = new System.Drawing.Point(76, 334);
            this.txtNombreCte.Name = "txtNombreCte";
            this.txtNombreCte.ReadOnly = true;
            this.txtNombreCte.ShortcutsEnabled = false;
            this.txtNombreCte.Size = new System.Drawing.Size(100, 23);
            this.txtNombreCte.TabIndex = 12;
            // 
            // txtApellidoCte
            // 
            this.txtApellidoCte.Location = new System.Drawing.Point(76, 355);
            this.txtApellidoCte.Name = "txtApellidoCte";
            this.txtApellidoCte.ReadOnly = true;
            this.txtApellidoCte.Size = new System.Drawing.Size(100, 23);
            this.txtApellidoCte.TabIndex = 13;
            // 
            // txtCuilCte
            // 
            this.txtCuilCte.Location = new System.Drawing.Point(76, 377);
            this.txtCuilCte.Name = "txtCuilCte";
            this.txtCuilCte.ReadOnly = true;
            this.txtCuilCte.Size = new System.Drawing.Size(100, 23);
            this.txtCuilCte.TabIndex = 14;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // CantidadDisponible
            // 
            this.CantidadDisponible.HeaderText = "CantidadDisponible";
            this.CantidadDisponible.Name = "CantidadDisponible";
            this.CantidadDisponible.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Precio Total: ";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.BackColor = System.Drawing.Color.White;
            this.txtPrecioTotal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPrecioTotal.Location = new System.Drawing.Point(445, 395);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.ReadOnly = true;
            this.txtPrecioTotal.Size = new System.Drawing.Size(135, 23);
            this.txtPrecioTotal.TabIndex = 16;
            // 
            // txtSaldoCliente
            // 
            this.txtSaldoCliente.Location = new System.Drawing.Point(445, 350);
            this.txtSaldoCliente.Name = "txtSaldoCliente";
            this.txtSaldoCliente.ReadOnly = true;
            this.txtSaldoCliente.Size = new System.Drawing.Size(135, 23);
            this.txtSaldoCliente.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Saldo Disponible";
            // 
            // FormCreacionOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 591);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSaldoCliente);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCuilCte);
            this.Controls.Add(this.txtApellidoCte);
            this.Controls.Add(this.txtNombreCte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnRealizarPedido);
            this.Controls.Add(this.dgvOrdenCompra);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.BtnAnadir);
            this.Name = "FormCreacionOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVentas1";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAnadir;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridView dgvOrdenCompra;
        private System.Windows.Forms.Button BtnRealizarPedido;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreCte;
        private System.Windows.Forms.TextBox txtApellidoCte;
        private System.Windows.Forms.TextBox txtCuilCte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDisponible;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.TextBox txtSaldoCliente;
        private System.Windows.Forms.Label label7;
    }
}