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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTipoAcesso = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lklRegistrar = new System.Windows.Forms.LinkLabel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Location = new System.Drawing.Point(40, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";

            // txtEmail
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Location = new System.Drawing.Point(40, 106);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 30);
            this.txtEmail.TabIndex = 1;

            // lblTipoAcesso
            this.lblTipoAcesso.AutoSize = true;
            this.lblTipoAcesso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTipoAcesso.Location = new System.Drawing.Point(40, 156);
            this.lblTipoAcesso.Name = "lblTipoAcesso";
            this.lblTipoAcesso.Size = new System.Drawing.Size(117, 23);
            this.lblTipoAcesso.TabIndex = 2;
            this.lblTipoAcesso.Text = "Tipo de Acesso:";

            // cmbTipo
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipo.FormattingEnabled = true;

            this.cmbTipo.Location = new System.Drawing.Point(40, 182);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(320, 31);
            this.cmbTipo.TabIndex = 3;

            // btnEntrar
            this.btnEntrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(40, 250);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(320, 40);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);

            // lklRegistrar
            this.lklRegistrar.AutoSize = true;
            this.lklRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lklRegistrar.LinkColor = System.Drawing.Color.SteelBlue;
            this.lklRegistrar.Location = new System.Drawing.Point(150, 310);
            this.lklRegistrar.Name = "lklRegistrar";
            this.lklRegistrar.Size = new System.Drawing.Size(100, 20);
            this.lklRegistrar.TabIndex = 5;
            this.lklRegistrar.TabStop = true;
            this.lklRegistrar.Text = "Criar conta";
            this.lklRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lklRegistrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklRegistrar_LinkClicked);

            // panelLogin
            this.panelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.lblTitulo);
            this.panelLogin.Controls.Add(this.lblEmail);
            this.panelLogin.Controls.Add(this.lklRegistrar);
            this.panelLogin.Controls.Add(this.txtEmail);
            this.panelLogin.Controls.Add(this.btnEntrar);
            this.panelLogin.Controls.Add(this.lblTipoAcesso);
            this.panelLogin.Controls.Add(this.cmbTipo);
            this.panelLogin.Location = new System.Drawing.Point(200, 50);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(400, 380);
            this.panelLogin.TabIndex = 6;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(50, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 28);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "ACESSO AO SISTEMA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // LoginForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelLogin);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Sistema Chamado";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
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