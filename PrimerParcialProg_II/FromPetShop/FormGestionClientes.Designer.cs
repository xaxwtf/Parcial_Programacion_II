
namespace FromPetShop
{
    partial class FormGestionClientes
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
            this.BtnAltaCte = new System.Windows.Forms.Button();
            this.BtnModCte = new System.Windows.Forms.Button();
            this.BtnBajaCte = new System.Windows.Forms.Button();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAltaCte
            // 
            this.BtnAltaCte.Location = new System.Drawing.Point(21, 28);
            this.BtnAltaCte.Name = "BtnAltaCte";
            this.BtnAltaCte.Size = new System.Drawing.Size(161, 23);
            this.BtnAltaCte.TabIndex = 0;
            this.BtnAltaCte.Text = "Alta Cliente";
            this.BtnAltaCte.UseVisualStyleBackColor = true;
            this.BtnAltaCte.Click += new System.EventHandler(this.BtnAltaCte_Click);
            // 
            // BtnModCte
            // 
            this.BtnModCte.Location = new System.Drawing.Point(21, 57);
            this.BtnModCte.Name = "BtnModCte";
            this.BtnModCte.Size = new System.Drawing.Size(161, 23);
            this.BtnModCte.TabIndex = 1;
            this.BtnModCte.Text = "Mostrar Clientes";
            this.BtnModCte.UseVisualStyleBackColor = true;
            this.BtnModCte.Click += new System.EventHandler(this.BtnMostrarCtes_Click);
            // 
            // BtnBajaCte
            // 
            this.BtnBajaCte.Location = new System.Drawing.Point(21, 86);
            this.BtnBajaCte.Name = "BtnBajaCte";
            this.BtnBajaCte.Size = new System.Drawing.Size(161, 23);
            this.BtnBajaCte.TabIndex = 2;
            this.BtnBajaCte.Text = "Baja Cliente";
            this.BtnBajaCte.UseVisualStyleBackColor = true;
            this.BtnBajaCte.Click += new System.EventHandler(this.BtnBajaCte_Click);
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(42, 145);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(114, 23);
            this.BtnAtras.TabIndex = 3;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // FormGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 180);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.BtnBajaCte);
            this.Controls.Add(this.BtnModCte);
            this.Controls.Add(this.BtnAltaCte);
            this.Name = "FormGestionClientes";
            this.Text = "FormGestionClientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAltaCte;
        private System.Windows.Forms.Button BtnModCte;
        private System.Windows.Forms.Button BtnBajaCte;
        private System.Windows.Forms.Button BtnAtras;
    }
}