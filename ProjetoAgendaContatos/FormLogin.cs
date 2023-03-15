using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgendaContatos
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        Cl_Login lgn = new Cl_Login();
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtBoxLogin.Text == "" || txtBoxSenha.Text == "")
            {
                MessageBox.Show("Digite Login e senha para acessar o sistema!!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    bool logar = lgn.Logar(txtBoxLogin.Text, txtBoxSenha.Text);

                    if (logar == true)
                    {
                        FormPrincipal principal = new FormPrincipal();
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login e/ou senha inválidos!!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBoxLogin.Clear();
                        txtBoxSenha.Clear();
                        txtBoxLogin.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
    

