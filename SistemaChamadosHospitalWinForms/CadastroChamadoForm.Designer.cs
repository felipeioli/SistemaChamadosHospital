namespace SistemaChamadoHospitalWinForms
{
    partial class CadastroChamadoForm
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
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            lblPrioridade = new Label();
            cmbPrioridade = new ComboBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 52);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(77, 20);
            lblDescricao.TabIndex = 0;
            lblDescricao.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 75);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(776, 27);
            txtDescricao.TabIndex = 1;
            // 
            // lblPrioridade
            // 
            lblPrioridade.AutoSize = true;
            lblPrioridade.Location = new Point(12, 147);
            lblPrioridade.Name = "lblPrioridade";
            lblPrioridade.Size = new Size(81, 20);
            lblPrioridade.TabIndex = 2;
            lblPrioridade.Text = "Prioridade:";
            // 
            // cmbPrioridade
            // 
            cmbPrioridade.FormattingEnabled = true;
            cmbPrioridade.Location = new Point(12, 170);
            cmbPrioridade.Name = "cmbPrioridade";
            cmbPrioridade.Size = new Size(151, 28);
            cmbPrioridade.TabIndex = 3;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(12, 218);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(151, 29);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar Chamado";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // CadastroChamadoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(cmbPrioridade);
            Controls.Add(lblPrioridade);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Name = "CadastroChamadoForm";
            Text = "Tela de Cadastro de Chamado";
            Load += CadastroChamadoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescricao;
        private TextBox txtDescricao;
        private Label lblPrioridade;
        private ComboBox cmbPrioridade;
        private Button btnCadastrar;
    }
}