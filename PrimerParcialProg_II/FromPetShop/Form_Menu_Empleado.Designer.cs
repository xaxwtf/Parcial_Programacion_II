
namespace FromPetShop
{
    partial class Form_Menu_Empleado
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
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.picImageUser = new System.Windows.Forms.PictureBox();
            this.BtnSwapPasword = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImageUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(24, 27);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(47, 15);
            this.lblusuario.TabIndex = 0;
            this.lblusuario.Text = "Usuario";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(77, 24);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(134, 23);
            this.txtIdUsuario.TabIndex = 1;
            // 
            // BtnVentas
            // 
            this.BtnVentas.Location = new System.Drawing.Point(261, 23);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(107, 23);
            this.BtnVentas.TabIndex = 2;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.UseVisualStyleBackColor = true;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // picImageUser
            // 
            this.picImageUser.Location = new System.Drawing.Point(24, 53);
            this.picImageUser.Name = "picImageUser";
            this.picImageUser.Size = new System.Drawing.Size(187, 160);
            this.picImageUser.TabIndex = 3;
            this.picImageUser.TabStop = false;
            // 
            // BtnSwapPasword
            // 
            this.BtnSwapPasword.Location = new System.Drawing.Point(24, 218);
            this.BtnSwapPasword.Name = "BtnSwapPasword";
            this.BtnSwapPasword.Size = new System.Drawing.Size(187, 23);
            this.BtnSwapPasword.TabIndex = 4;
            this.BtnSwapPasword.Text = "Cambiar Contraseña";
            this.BtnSwapPasword.UseVisualStyleBackColor = true;
            this.BtnSwapPasword.Click += new System.EventHandler(this.BtnSwapPasword_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(261, 218);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(107, 23);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Form_Menu_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(420, 253);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnSwapPasword);
            this.Controls.Add(this.picImageUser);
            this.Controls.Add(this.BtnVentas);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.lblusuario);
            this.Name = "Form_Menu_Empleado";
            this.Text = "Form_Menu_Empleado";
            this.Load += new System.EventHandler(this.Form_Menu_Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImageUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusuario;
        protected System.Windows.Forms.Button BtnVentas;
        protected System.Windows.Forms.Button BtnSwapPasword;
        protected System.Windows.Forms.Button BtnSalir;
        protected System.Windows.Forms.TextBox txtIdUsuario;
        protected System.Windows.Forms.PictureBox picImageUser;
    }
}