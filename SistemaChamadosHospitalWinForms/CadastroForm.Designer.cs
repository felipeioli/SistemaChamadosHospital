namespace SistemaChamadoHospitalWinForms
{
    partial class CadastroForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            lklTelaLogin = new LinkLabel();
            panelCadastro = new Panel();
            lblSenha = new Label();
            txtSenha = new TextBox();
            panelCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10F);
            lblNome.ForeColor = Color.FromArgb(64, 64, 64);
            lblNome.Location = new Point(40, 20);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(68, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:*";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.FromArgb(64, 64, 64);
            lblEmail.Location = new Point(40, 88);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 23);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:*";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 10F);
            lblTipo.ForeColor = Color.FromArgb(64, 64, 64);
            lblTipo.Location = new Point(40, 226);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(135, 23);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo de Acesso:*";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.WhiteSmoke;
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.ForeColor = Color.FromArgb(64, 64, 64);
            txtNome.Location = new Point(40, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(320, 30);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.WhiteSmoke;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(40, 114);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 30);
            txtEmail.TabIndex = 2;
            // 
            // cmbTipo
            // 
            cmbTipo.BackColor = Color.WhiteSmoke;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FlatStyle = FlatStyle.Flat;
            cmbTipo.Font = new Font("Segoe UI", 10F);
            cmbTipo.ForeColor = Color.FromArgb(64, 64, 64);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(40, 252);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(320, 31);
            cmbTipo.TabIndex = 3;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(52, 73, 94);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(40, 370);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(320, 40);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblAreaTrabalho
            // 
            lblAreaTrabalho.AutoSize = true;
            lblAreaTrabalho.Font = new Font("Segoe UI", 10F);
            lblAreaTrabalho.ForeColor = Color.FromArgb(64, 64, 64);
            lblAreaTrabalho.Location = new Point(40, 297);
            lblAreaTrabalho.Name = "lblAreaTrabalho";
            lblAreaTrabalho.Size = new Size(147, 23);
            lblAreaTrabalho.TabIndex = 4;
            lblAreaTrabalho.Text = "Área de Trabalho*";
            lblAreaTrabalho.Visible = false;
            // 
            // txtAreaTrabalho
            // 
            txtAreaTrabalho.BackColor = Color.WhiteSmoke;
            txtAreaTrabalho.BorderStyle = BorderStyle.FixedSingle;
            txtAreaTrabalho.Font = new Font("Segoe UI", 10F);
            txtAreaTrabalho.ForeColor = Color.FromArgb(64, 64, 64);
            txtAreaTrabalho.Location = new Point(40, 323);
            txtAreaTrabalho.Name = "txtAreaTrabalho";
            txtAreaTrabalho.Size = new Size(320, 30);
            txtAreaTrabalho.TabIndex = 4;
            txtAreaTrabalho.Visible = false;
            // 
            // lklTelaLogin
            // 
            lklTelaLogin.ActiveLinkColor = Color.SteelBlue;
            lklTelaLogin.AutoSize = true;
            lklTelaLogin.Font = new Font("Segoe UI", 9F);
            lklTelaLogin.LinkBehavior = LinkBehavior.HoverUnderline;
            lklTelaLogin.LinkColor = Color.SteelBlue;
            lklTelaLogin.Location = new Point(121, 428);
            lklTelaLogin.Name = "lklTelaLogin";
            lklTelaLogin.Size = new Size(170, 20);
            lklTelaLogin.TabIndex = 7;
            lklTelaLogin.TabStop = true;
            lklTelaLogin.Text = "Voltar para tela de login";
            lklTelaLogin.LinkClicked += lklTelaLogin_LinkClicked;
            // 
            // panelCadastro
            // 
            panelCadastro.Anchor = AnchorStyles.None;
            panelCadastro.BackColor = Color.White;
            panelCadastro.BorderStyle = BorderStyle.FixedSingle;
            panelCadastro.Controls.Add(lblNome);
            panelCadastro.Controls.Add(txtNome);
            panelCadastro.Controls.Add(lblEmail);
            panelCadastro.Controls.Add(txtEmail);
            panelCadastro.Controls.Add(lblTipo);
            panelCadastro.Controls.Add(cmbTipo);
            panelCadastro.Controls.Add(lblAreaTrabalho);
            panelCadastro.Controls.Add(txtAreaTrabalho);
            panelCadastro.Controls.Add(lblSenha);
            panelCadastro.Controls.Add(txtSenha);
            panelCadastro.Controls.Add(btnSalvar);
            panelCadastro.Controls.Add(lklTelaLogin);
            panelCadastro.Location = new Point(431, 146);
            panelCadastro.Name = "panelCadastro";
            panelCadastro.Padding = new Padding(20);
            panelCadastro.Size = new Size(400, 470);
            panelCadastro.TabIndex = 10;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 10F);
            lblSenha.ForeColor = Color.FromArgb(64, 64, 64);
            lblSenha.Location = new Point(40, 158);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(68, 23);
            lblSenha.TabIndex = 5;
            lblSenha.Text = "Senha:*";
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.WhiteSmoke;
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Font = new Font("Segoe UI", 10F);
            txtSenha.ForeColor = Color.FromArgb(64, 64, 64);
            txtSenha.Location = new Point(40, 184);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '●';
            txtSenha.Size = new Size(320, 30);
            txtSenha.TabIndex = 5;
            // 
            // CadastroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 250);
            ClientSize = new Size(1262, 743);
            Controls.Add(panelCadastro);
            MinimumSize = new Size(600, 400);
            Name = "CadastroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro - Sistema Chamado";
            Load += CadastroForm_Load;
            panelCadastro.ResumeLayout(false);
            panelCadastro.PerformLayout();
            ResumeLayout(false);
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
        private LinkLabel lklTelaLogin;
        private Panel panelCadastro;
        private Label lblSenha;
        private TextBox txtSenha;
    }
}
    