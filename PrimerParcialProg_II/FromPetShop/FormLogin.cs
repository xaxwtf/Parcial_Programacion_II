﻿using System;
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
    public partial class FormLogin : Form
    {
        Comercio petShop = new Comercio("clarita");
        User usuarioAtivo;
        
        public FormLogin()
        {
            petShop.HarcodearDatos();
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            usuarioAtivo =petShop.LogearUsuario(this.txtId.Text, this.txtPasword.Text);
                switch (petShop.Conectado)
                {
                    case EstadoDeSesion.ConectadoAdministrador:
                  
                        break;
                    case EstadoDeSesion.ConectadoEmpleado:
                        FormMenuEmpleado empleado = new FormMenuEmpleado();
                        empleado.ShowDialog();
                        break;
                    case EstadoDeSesion.ConectadoSuperUsuario:
                    FormMenuSuperUser SUsers = new FormMenuSuperUser();
                    SUsers.Show();
                        break;
                    case EstadoDeSesion.Desconectado:
                    
                    break;                                                                 
                }
            petShop.Desconectar();
        }

        private void btnSUser_Click(object sender, EventArgs e)
        {
            this.txtId.Text = "admin";
            this.txtPasword.Text = "admin";
        }

        private void btnUnEmpleado_Click(object sender, EventArgs e)
        {
            this.txtId.Text = "juan23";
            this.txtPasword.Text = "11111";
        }

        private void btnUnAdmin_Click(object sender, EventArgs e)
        {
            this.txtId.Text = "carlos_21";
            this.txtPasword.Text = "22222";
        }
    }
}
