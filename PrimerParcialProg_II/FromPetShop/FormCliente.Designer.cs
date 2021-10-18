
namespace FromPetShop
{
    partial class FormCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNCteCuil = new System.Windows.Forms.TextBox();
            this.txtNCteNombre = new System.Windows.Forms.TextBox();
            this.txtNCteApellido = new System.Windows.Forms.TextBox();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUIL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // txtNCteCuil
            // 
            this.txtNCteCuil.Location = new System.Drawing.Point(88, 28);
            this.txtNCteCuil.Name = "txtNCteCuil";
            this.txtNCteCuil.Size = new System.Drawing.Size(126, 23);
            this.txtNCteCuil.TabIndex = 3;
            // 
            // txtNCteNombre
            // 
            this.txtNCteNombre.Location = new System.Drawing.Point(88, 57);
            this.txtNCteNombre.Name = "txtNCteNombre";
            this.txtNCteNombre.Size = new System.Drawing.Size(126, 23);
            this.txtNCteNombre.TabIndex = 4;
            // 
            // txtNCteApellido
            // 
            this.txtNCteApellido.Location = new System.Drawing.Point(88, 86);
            this.txtNCteApellido.Name = "txtNCteApellido";
            this.txtNCteApellido.Size = new System.Drawing.Size(126, 23);
            this.txtNCteApellido.TabIndex = 5;
            // 
            // BtnCrear
            // 
            this.BtnCrear.Location = new System.Drawing.Point(28, 161);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(75, 23);
            this.BtnCrear.TabIndex = 6;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(139, 161);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(88, 113);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(126, 23);
            this.txtEfectivo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Efectivo";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 196);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.txtNCteApellido);
            this.Controls.Add(this.txtNCteNombre);
            this.Controls.Add(this.txtNCteCuil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNCteCuil;
        private System.Windows.Forms.TextBox txtNCteNombre;
        private System.Windows.Forms.TextBox txtNCteApellido;
        private System.Windows.Forms.Button BtnCrear;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label label4;
    }
}