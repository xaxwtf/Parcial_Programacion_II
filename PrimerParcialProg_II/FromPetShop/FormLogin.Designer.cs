
namespace FromPetShop
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUnEmpleado = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPasword = new System.Windows.Forms.TextBox();
            this.btnSUser = new System.Windows.Forms.Button();
            this.btnUnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "PASWORD";
            // 
            // btnUnEmpleado
            // 
            this.btnUnEmpleado.Location = new System.Drawing.Point(264, 143);
            this.btnUnEmpleado.Name = "btnUnEmpleado";
            this.btnUnEmpleado.Size = new System.Drawing.Size(119, 23);
            this.btnUnEmpleado.TabIndex = 5;
            this.btnUnEmpleado.Text = "infoUnEmpleado";
            this.btnUnEmpleado.UseVisualStyleBackColor = true;
            this.btnUnEmpleado.Click += new System.EventHandler(this.btnUnEmpleado_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(95, 135);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 43);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(95, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(244, 23);
            this.txtId.TabIndex = 0;
            // 
            // txtPasword
            // 
            this.txtPasword.Location = new System.Drawing.Point(95, 85);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.Size = new System.Drawing.Size(244, 23);
            this.txtPasword.TabIndex = 1;
            // 
            // btnSUser
            // 
            this.btnSUser.Location = new System.Drawing.Point(264, 114);
            this.btnSUser.Name = "btnSUser";
            this.btnSUser.Size = new System.Drawing.Size(119, 23);
            this.btnSUser.TabIndex = 6;
            this.btnSUser.Text = "InfoS_user";
            this.btnSUser.UseVisualStyleBackColor = true;
            this.btnSUser.Click += new System.EventHandler(this.btnSUser_Click);
            // 
            // btnUnAdmin
            // 
            this.btnUnAdmin.Location = new System.Drawing.Point(264, 172);
            this.btnUnAdmin.Name = "btnUnAdmin";
            this.btnUnAdmin.Size = new System.Drawing.Size(119, 23);
            this.btnUnAdmin.TabIndex = 7;
            this.btnUnAdmin.Text = "infoUnAdmin";
            this.btnUnAdmin.UseVisualStyleBackColor = true;
            this.btnUnAdmin.Click += new System.EventHandler(this.btnUnAdmin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(417, 204);
            this.Controls.Add(this.btnUnAdmin);
            this.Controls.Add(this.btnSUser);
            this.Controls.Add(this.btnUnEmpleado);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasword);
            this.Controls.Add(this.txtId);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUnEmpleado;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPasword;
        private System.Windows.Forms.Button btnSUser;
        private System.Windows.Forms.Button btnUnAdmin;
    }
}

