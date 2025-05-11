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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblAreaTrabalho = new System.Windows.Forms.Label();
            this.txtAreaTrabalho = new System.Windows.Forms.TextBox();
            this.lklTelaLogin = new System.Windows.Forms.LinkLabel();
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.panelCadastro.SuspendLayout();
            this.SuspendLayout();

            // lblNome
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNome.Location = new System.Drawing.Point(40, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 23);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmail.Location = new System.Drawing.Point(40, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 23);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";

            // lblTipo
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTipo.Location = new System.Drawing.Point(40, 170);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(117, 23);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo de Acesso:";

            // txtNome
            this.txtNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.Location = new System.Drawing.Point(40, 56);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(320, 30);
            this.txtNome.TabIndex = 1;

            // txtEmail
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(40, 126);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 30);
            this.txtEmail.TabIndex = 2;

            // cmbTipo
            this.cmbTipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(40, 196);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(320, 31);
            this.cmbTipo.TabIndex = 3;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);

            // btnSalvar
            this.btnSalvar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(40, 340);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(320, 40);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);

            // lblAreaTrabalho
            this.lblAreaTrabalho.AutoSize = true;
            this.lblAreaTrabalho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAreaTrabalho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAreaTrabalho.Location = new System.Drawing.Point(40, 240);
            this.lblAreaTrabalho.Name = "lblAreaTrabalho";
            this.lblAreaTrabalho.Size = new System.Drawing.Size(127, 23);
            this.lblAreaTrabalho.TabIndex = 7;
            this.lblAreaTrabalho.Text = "Área de Trabalho";
            this.lblAreaTrabalho.Visible = false;

            // txtAreaTrabalho
            this.txtAreaTrabalho.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAreaTrabalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAreaTrabalho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAreaTrabalho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAreaTrabalho.Location = new System.Drawing.Point(40, 266);
            this.txtAreaTrabalho.Name = "txtAreaTrabalho";
            this.txtAreaTrabalho.Size = new System.Drawing.Size(320, 30);
            this.txtAreaTrabalho.TabIndex = 4;
            this.txtAreaTrabalho.Visible = false;

            // lklTelaLogin
            this.lklTelaLogin.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.lklTelaLogin.AutoSize = true;
            this.lklTelaLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lklTelaLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lklTelaLogin.LinkColor = System.Drawing.Color.SteelBlue;
            this.lklTelaLogin.Location = new System.Drawing.Point(120, 400);
            this.lklTelaLogin.Name = "lklTelaLogin";
            this.lklTelaLogin.Size = new System.Drawing.Size(160, 20);
            this.lklTelaLogin.TabIndex = 6;
            this.lklTelaLogin.TabStop = true;
            this.lklTelaLogin.Text = "Voltar para tela de login";
            this.lklTelaLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lklTelaLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklTelaLogin_LinkClicked);

            // panelCadastro
            this.panelCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCadastro.BackColor = System.Drawing.Color.White;
            this.panelCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCadastro.Controls.Add(this.lblNome);
            this.panelCadastro.Controls.Add(this.lklTelaLogin);
            this.panelCadastro.Controls.Add(this.txtNome);
            this.panelCadastro.Controls.Add(this.txtAreaTrabalho);
            this.panelCadastro.Controls.Add(this.lblEmail);
            this.panelCadastro.Controls.Add(this.lblAreaTrabalho);
            this.panelCadastro.Controls.Add(this.txtEmail);
            this.panelCadastro.Controls.Add(this.btnSalvar);
            this.panelCadastro.Controls.Add(this.lblTipo);
            this.panelCadastro.Controls.Add(this.cmbTipo);
            this.panelCadastro.Location = new System.Drawing.Point(200, 50);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Padding = new System.Windows.Forms.Padding(20);
            this.panelCadastro.Size = new System.Drawing.Size(400, 450);
            this.panelCadastro.TabIndex = 10;

            // CadastroForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.panelCadastro);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "CadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro - Sistema Hospitalar";
            this.Load += new System.EventHandler(this.CadastroForm_Load);
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            this.ResumeLayout(false);
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