namespace SistemaChamadoHospitalWinForms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblSenha = new Label();
            txtSenha = new TextBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            btnEntrar = new Button();
            lklRegistrar = new LinkLabel();
            panelLogin = new Panel();

            panelLogin.SuspendLayout();
            SuspendLayout();

            // lblEmail
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(40, 30);
            lblEmail.Text = "Email:";

            // txtEmail
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(40, 55);
            txtEmail.Size = new Size(320, 30);

            // lblSenha
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 10F);
            lblSenha.Location = new Point(40, 95);
            lblSenha.Text = "Senha:";

            // txtSenha
            txtSenha.Font = new Font("Segoe UI", 10F);
            txtSenha.Location = new Point(40, 120);
            txtSenha.Size = new Size(320, 30);
            txtSenha.PasswordChar = '*';

            // lblTipo
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 10F);
            lblTipo.Location = new Point(40, 160);
            lblTipo.Text = "Tipo de Acesso:";

            // cmbTipo
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Font = new Font("Segoe UI", 10F);
            cmbTipo.Location = new Point(40, 185);
            cmbTipo.Size = new Size(320, 31);

            // btnEntrar
            btnEntrar.BackColor = Color.FromArgb(52, 152, 219);
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(40, 230);
            btnEntrar.Size = new Size(320, 40);
            btnEntrar.Text = "ENTRAR";
            btnEntrar.Click += btnEntrar_Click;

            // lklRegistrar
            lklRegistrar.AutoSize = true;
            lklRegistrar.Font = new Font("Segoe UI", 9F);
            lklRegistrar.LinkColor = Color.SteelBlue;
            lklRegistrar.Location = new Point(110, 280);
            lklRegistrar.Text = "Não tem conta? Cadastre-se";
            lklRegistrar.LinkClicked += lklRegistrar_LinkClicked;

            // panelLogin
            panelLogin.Anchor = AnchorStyles.None;
            panelLogin.BackColor = Color.White;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(lblEmail);
            panelLogin.Controls.Add(txtEmail);
            panelLogin.Controls.Add(lblSenha);
            panelLogin.Controls.Add(txtSenha);
            panelLogin.Controls.Add(lblTipo);
            panelLogin.Controls.Add(cmbTipo);
            panelLogin.Controls.Add(btnEntrar);
            panelLogin.Controls.Add(lklRegistrar);
            panelLogin.Location = new Point(400, 140);
            panelLogin.Size = new Size(400, 330);

            // LoginForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            BackColor = Color.FromArgb(240, 245, 250);
            Controls.Add(panelLogin);
            Text = "Login - Sistema Chamado";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginForm_Load;

            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panelLogin;
        private Label lblEmail, lblSenha, lblTipo;
        private TextBox txtEmail, txtSenha;
        private ComboBox cmbTipo;
        private Button btnEntrar;
        private LinkLabel lklRegistrar;
    }
}
