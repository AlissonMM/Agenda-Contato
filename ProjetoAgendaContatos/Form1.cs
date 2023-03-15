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
    public partial class FormPrincipal : MaterialSkin.Controls.MaterialForm
    {
        cl_ControleContato controle = new cl_ControleContato();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cl_Conexao c = new cl_Conexao();
            MessageBox.Show(c.conectar());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastro cadastro = new FormCadastro();
            cadastro.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta consulta = new frmConsulta();
            consulta.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controle.Backup("C:\\Backup"), "Backup do Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void restauraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string CaminhoBackup = openFileDialog1.FileName;
                MessageBox.Show(controle.Restore(CaminhoBackup), "Restauração do BD",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
