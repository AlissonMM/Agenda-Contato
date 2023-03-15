namespace ProjetoAgendaContatos
{
    partial class frmConsulta
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
            this.lblEscolha = new System.Windows.Forms.Label();
            this.cmbBoxEscolha = new System.Windows.Forms.ComboBox();
            this.lblcod = new System.Windows.Forms.Label();
            this.txtBoxCod = new System.Windows.Forms.TextBox();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.btnListar = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Location = new System.Drawing.Point(32, 87);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(140, 13);
            this.lblEscolha.TabIndex = 0;
            this.lblEscolha.Text = "Escolha a opção de busca: ";
            // 
            // cmbBoxEscolha
            // 
            this.cmbBoxEscolha.FormattingEnabled = true;
            this.cmbBoxEscolha.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "Telefone",
            "Celular",
            "Email"});
            this.cmbBoxEscolha.Location = new System.Drawing.Point(35, 103);
            this.cmbBoxEscolha.Name = "cmbBoxEscolha";
            this.cmbBoxEscolha.Size = new System.Drawing.Size(137, 21);
            this.cmbBoxEscolha.TabIndex = 1;
            this.cmbBoxEscolha.SelectedIndexChanged += new System.EventHandler(this.cmbBoxEscolha_SelectedIndexChanged);
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(32, 153);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(79, 13);
            this.lblcod.TabIndex = 2;
            this.lblcod.Text = "Digite o Código";
            // 
            // txtBoxCod
            // 
            this.txtBoxCod.Location = new System.Drawing.Point(35, 169);
            this.txtBoxCod.Name = "txtBoxCod";
            this.txtBoxCod.Size = new System.Drawing.Size(137, 20);
            this.txtBoxCod.TabIndex = 3;
            this.txtBoxCod.TextChanged += new System.EventHandler(this.txtBoxOpcao_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(191, 160);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(77, 36);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnListar
            // 
            this.btnListar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnListar.Depth = 0;
            this.btnListar.HighEmphasis = true;
            this.btnListar.Icon = null;
            this.btnListar.Location = new System.Drawing.Point(35, 198);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(121, 36);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar todos";
            this.btnListar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnListar.UseAccentColor = false;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 204);
            this.dataGridView1.TabIndex = 6;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBoxCod);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.cmbBoxEscolha);
            this.Controls.Add(this.lblEscolha);
            this.Name = "frmConsulta";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.ComboBox cmbBoxEscolha;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.TextBox txtBoxCod;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private MaterialSkin.Controls.MaterialButton btnListar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}