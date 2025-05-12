namespace SistemaChamadoHospitalWinForms
{
    partial class LoginForm
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
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblTipoAcesso = new Label();
            cmbTipo = new ComboBox();
            btnEntrar = new Button();
            lklRegistrar = new LinkLabel();
            panelLogin = new Panel();
            lblTitulo = new Label();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(40, 80);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 23);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(40, 106);
            txtEmail.Margin = new Padding(3, 3, 3, 10);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 30);
            txtEmail.TabIndex = 1;
            // 
            // lblTipoAcesso
            // 
            lblTipoAcesso.AutoSize = true;
            lblTipoAcesso.Font = new Font("Segoe UI", 10F);
            lblTipoAcesso.Location = new Point(40, 156);
            lblTipoAcesso.Name = "lblTipoAcesso";
            lblTipoAcesso.Size = new Size(128, 23);
            lblTipoAcesso.TabIndex = 2;
            lblTipoAcesso.Text = "Tipo de Acesso:";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Font = new Font("Segoe UI", 10F);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(40, 182);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(320, 31);
            cmbTipo.TabIndex = 3;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(52, 73, 94);
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(40, 250);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(320, 40);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lklRegistrar
            // 
            lklRegistrar.AutoSize = true;
            lklRegistrar.Font = new Font("Segoe UI", 9F);
            lklRegistrar.LinkColor = Color.SteelBlue;
            lklRegistrar.Location = new Point(150, 310);
            lklRegistrar.Name = "lklRegistrar";
            lklRegistrar.Size = new Size(81, 20);
            lklRegistrar.TabIndex = 5;
            lklRegistrar.TabStop = true;
            lklRegistrar.Text = "Criar conta";
            lklRegistrar.TextAlign = ContentAlignment.MiddleCenter;
            lklRegistrar.LinkClicked += lklRegistrar_LinkClicked;
            // 
            // panelLogin
            // 
            panelLogin.Anchor = AnchorStyles.None;
            panelLogin.BackColor = Color.White;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(lblTitulo);
            panelLogin.Controls.Add(lblEmail);
            panelLogin.Controls.Add(lklRegistrar);
            panelLogin.Controls.Add(txtEmail);
            panelLogin.Controls.Add(btnEntrar);
            panelLogin.Controls.Add(lblTipoAcesso);
            panelLogin.Controls.Add(cmbTipo);
            panelLogin.Location = new Point(431, 171);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(400, 380);
            panelLogin.TabIndex = 6;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(50, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(211, 28);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "ACESSO AO SISTEMA";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 250);
            ClientSize = new Size(1262, 743);
            Controls.Add(panelLogin);
            MinimumSize = new Size(600, 400);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Sistema Chamado";
            Load += LoginForm_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTipoAcesso;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.LinkLabel lklRegistrar;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblTitulo;
    }
}