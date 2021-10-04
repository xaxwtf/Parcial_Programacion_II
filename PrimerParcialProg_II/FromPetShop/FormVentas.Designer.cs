
namespace FromPetShop
{
    partial class FormVentas1
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
            this.btnRVenta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRVenta
            // 
            this.btnRVenta.Location = new System.Drawing.Point(46, 35);
            this.btnRVenta.Name = "btnRVenta";
            this.btnRVenta.Size = new System.Drawing.Size(96, 23);
            this.btnRVenta.TabIndex = 0;
            this.btnRVenta.Text = "Realizar Venta";
            this.btnRVenta.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(46, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(46, 93);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(96, 23);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // FormVentas1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 310);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRVenta);
            this.Name = "FormVentas1";
            this.Text = "FormVentas1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRVenta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAtras;
    }
}