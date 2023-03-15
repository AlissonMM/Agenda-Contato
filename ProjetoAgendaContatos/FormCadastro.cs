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
    public partial class FormCadastro : MaterialSkin.Controls.MaterialForm
    {
        cl_Contato cont = new cl_Contato();
        cl_ControleContato controle = new cl_ControleContato();


        public FormCadastro()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            txtNome.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Não é permitido cadastro sem um nome!!!");
            }
            else
            {
                cont.Codcontato = Convert.ToInt32(txtCodigo.Text);
                cont.Nome = txtNome.Text;
                cont.Telefone = txtTelefone.Text;
                cont.Celular = txtCelular.Text;
                cont.Email = txtEmail.Text;

                MessageBox.Show(controle.cadastrar(cont));
                limpar();
                AlteraBotoes(1);

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controle.excluir(cont));
            limpar();
            AlteraBotoes(1);

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                cont.Codcontato = Convert.ToInt32(txtCodigo.Text);
                cont.Nome = txtNome.Text;
                cont.Telefone = txtTelefone.Text;
                cont.Celular = txtCelular.Text;
                cont.Email = txtEmail.Text;
            }
            catch
            {
                MessageBox.Show("preencha todas as informações");
            }
            MessageBox.Show(controle.Alterar(cont));
            AlteraBotoes(1);
            limpar();


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cont = controle.buscar(int.Parse(txtCodigo.Text));
                if (cont is null)
                {
                    MessageBox.Show("Não foi encontrado registro com o código informado!");
                    limpar();
                    txtCodigo.Focus();
                }
                else
                {
                    txtNome.Text = cont.Nome;
                    txtEmail.Text = cont.Email;
                    txtTelefone.Text = cont.Telefone;
                    txtCelular.Text = cont.Celular;
                    txtEmail.Text = cont.Email;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            AlteraBotoes(3);
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }
        public void AlteraBotoes(int op)
        {
            btnNovo.Enabled = false;
            btnCadastrar.Enabled = false;
            btnBuscar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;

            if (op == 1)
            {
                btnNovo.Enabled = true;
            }
            if (op == 2)
            {
                btnCadastrar.Enabled = true;
                btnCancelar.Enabled = true;
            }

            if (op == 3)
            {
                btnExcluir.Enabled = true;
                btnAlterar.Enabled = true;
                btnCancelar.Enabled = true;
            }


        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            AlteraBotoes(2);
            limpar();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AlteraBotoes(1);
            limpar();

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                btnBuscar.Enabled = false;
            }
            else
            {
                btnBuscar.Enabled = true;
            }

        }
    }
}
    

