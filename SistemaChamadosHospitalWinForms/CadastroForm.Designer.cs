namespace SistemaChamadoHospitalWinForms
{
    partial class CadastroForm
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
            lblNome = new Label();
            lblEmail = new Label();
            lblTipo = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            cmbTipo = new ComboBox();
            btnSalvar = new Button();
            lblAreaTrabalho = new Label();
            txtAreaTrabalho = new TextBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(255, 48);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(255, 128);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(255, 226);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(42, 20);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(255, 71);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(255, 168);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 4;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(255, 249);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(151, 28);
            cmbTipo.TabIndex = 5;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(255, 395);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblAreaTrabalho
            // 
            lblAreaTrabalho.AutoSize = true;
            lblAreaTrabalho.Location = new Point(255, 301);
            lblAreaTrabalho.Name = "lblAreaTrabalho";
            lblAreaTrabalho.Size = new Size(123, 20);
            lblAreaTrabalho.TabIndex = 7;
            lblAreaTrabalho.Text = "Area de Trabalho";
            // 
            // txtAreaTrabalho
            // 
            txtAreaTrabalho.Location = new Point(255, 333);
            txtAreaTrabalho.Name = "txtAreaTrabalho";
            txtAreaTrabalho.Size = new Size(125, 27);
            txtAreaTrabalho.TabIndex = 8;
            // 
            // CadastroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAreaTrabalho);
            Controls.Add(lblAreaTrabalho);
            Controls.Add(btnSalvar);
            Controls.Add(cmbTipo);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(lblTipo);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Name = "CadastroForm";
            Text = "Tela de Cadastro";
            Load += CadastroForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblEmail;
        private Label lblTipo;
        private TextBox txtNome;
        private TextBox txtEmail;
        private ComboBox cmbTipo;
        private Button btnSalvar;
        private Label lblAreaTrabalho;
        private TextBox txtAreaTrabalho;
    }
}