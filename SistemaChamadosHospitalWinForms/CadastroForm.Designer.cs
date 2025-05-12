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
            panelCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 10F);
            lblNome.ForeColor = Color.FromArgb(64, 64, 64);
            lblNome.Location = new Point(40, 30);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.FromArgb(64, 64, 64);
            lblEmail.Location = new Point(40, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 23);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 10F);
            lblTipo.ForeColor = Color.FromArgb(64, 64, 64);
            lblTipo.Location = new Point(40, 170);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(128, 23);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo de Acesso:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.WhiteSmoke;
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 10F);
            txtNome.ForeColor = Color.FromArgb(64, 64, 64);
            txtNome.Location = new Point(40, 56);
            txtNome.Margin = new Padding(3, 3, 3, 10);
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
            txtEmail.Location = new Point(40, 126);
            txtEmail.Margin = new Padding(3, 3, 3, 10);
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
            cmbTipo.Location = new Point(40, 196);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(320, 31);
            cmbTipo.TabIndex = 3;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(52, 73, 94);
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(40, 340);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(320, 40);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblAreaTrabalho
            // 
            lblAreaTrabalho.AutoSize = true;
            lblAreaTrabalho.Font = new Font("Segoe UI", 10F);
            lblAreaTrabalho.ForeColor = Color.FromArgb(64, 64, 64);
            lblAreaTrabalho.Location = new Point(40, 240);
            lblAreaTrabalho.Name = "lblAreaTrabalho";
            lblAreaTrabalho.Size = new Size(140, 23);
            lblAreaTrabalho.TabIndex = 7;
            lblAreaTrabalho.Text = "Área de Trabalho";
            lblAreaTrabalho.Visible = false;
            // 
            // txtAreaTrabalho
            // 
            txtAreaTrabalho.BackColor = Color.WhiteSmoke;
            txtAreaTrabalho.BorderStyle = BorderStyle.FixedSingle;
            txtAreaTrabalho.Font = new Font("Segoe UI", 10F);
            txtAreaTrabalho.ForeColor = Color.FromArgb(64, 64, 64);
            txtAreaTrabalho.Location = new Point(40, 266);
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
            lklTelaLogin.Location = new Point(120, 400);
            lklTelaLogin.Name = "lklTelaLogin";
            lklTelaLogin.Size = new Size(170, 20);
            lklTelaLogin.TabIndex = 6;
            lklTelaLogin.TabStop = true;
            lklTelaLogin.Text = "Voltar para tela de login";
            lklTelaLogin.TextAlign = ContentAlignment.MiddleCenter;
            lklTelaLogin.LinkClicked += lklTelaLogin_LinkClicked;
            // 
            // panelCadastro
            // 
            panelCadastro.Anchor = AnchorStyles.None;
            panelCadastro.BackColor = Color.White;
            panelCadastro.BorderStyle = BorderStyle.FixedSingle;
            panelCadastro.Controls.Add(lblNome);
            panelCadastro.Controls.Add(lklTelaLogin);
            panelCadastro.Controls.Add(txtNome);
            panelCadastro.Controls.Add(txtAreaTrabalho);
            panelCadastro.Controls.Add(lblEmail);
            panelCadastro.Controls.Add(lblAreaTrabalho);
            panelCadastro.Controls.Add(txtEmail);
            panelCadastro.Controls.Add(btnSalvar);
            panelCadastro.Controls.Add(lblTipo);
            panelCadastro.Controls.Add(cmbTipo);
            panelCadastro.Location = new Point(431, 146);
            panelCadastro.Name = "panelCadastro";
            panelCadastro.Padding = new Padding(20);
            panelCadastro.Size = new Size(400, 450);
            panelCadastro.TabIndex = 10;
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

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblAreaTrabalho;
        private System.Windows.Forms.TextBox txtAreaTrabalho;
        private System.Windows.Forms.LinkLabel lklTelaLogin;
        private System.Windows.Forms.Panel panelCadastro;
    }
}