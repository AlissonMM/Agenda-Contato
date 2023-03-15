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
    public partial class frmConsulta : MaterialSkin.Controls.MaterialForm
    {
        cl_Contato cont = new cl_Contato();

        cl_ControleContato controle = new cl_ControleContato();
        public frmConsulta()
        {

            InitializeComponent();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
           
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controle.PreencherTodos();
        }

        private void cmbBoxEscolha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxEscolha.SelectedIndex < 0)
            {
                txtBoxCod.Enabled = false;
                btnBuscar.Enabled = false;
                lblcod.Text = "";
            }
            else
            {
                txtBoxCod.Enabled = true;
                lblcod.Text = "Digite o" + cmbBoxEscolha.Text;
                txtBoxCod.Clear();
                txtBoxCod.Focus();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbBoxEscolha.SelectedIndex == 0)
            {
                try
                {
                    int codigo = Convert.ToInt32(txtBoxCod.Text);

                    dataGridView1.DataSource = controle.pesquisaCodigo(codigo);
                }
                catch
                {
                    MessageBox.Show("Digite um valor inteiro para código!");
                    txtBoxCod.Clear();
                    txtBoxCod.Focus();
                }
            }
            else if (cmbBoxEscolha.SelectedIndex == 1)
            {
                string nomecontato = (txtBoxCod.Text);

                dataGridView1.DataSource = controle.pesquisanome(nomecontato);
            }

            else if (cmbBoxEscolha.SelectedIndex == 2)
            {
                string telefonecod = (txtBoxCod.Text);

                dataGridView1.DataSource = controle.pesquisatelefone(telefonecod);
            }

            else if (cmbBoxEscolha.SelectedIndex == 3)
            {
                string cel = (txtBoxCod.Text);

                dataGridView1.DataSource = controle.pesquisacelular(cel);
            }

            else if (cmbBoxEscolha.SelectedIndex == 4)
            {
                string emailcod = (txtBoxCod.Text);

                dataGridView1.DataSource = controle.pesquisaemail(emailcod);
            }
        }

        private void txtBoxOpcao_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxCod.Text != "")
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }
    }
}
