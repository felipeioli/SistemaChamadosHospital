namespace SistemaChamadoHospitalWinForms
{
    partial class MinhaContaForm
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAreaTrabalho = new System.Windows.Forms.Label();
            this.txtAreaTrabalho = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panelConta = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelConta.SuspendLayout();
            this.SuspendLayout();

            // lblTipo
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTipo.Location = new System.Drawing.Point(40, 40);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(100, 23);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipo: Usuário";

            // lblNome
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNome.Location = new System.Drawing.Point(40, 90);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 23);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";

            // txtNome
            this.txtNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.Location = new System.Drawing.Point(40, 116);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(320, 30);
            this.txtNome.TabIndex = 1;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmail.Location = new System.Drawing.Point(40, 170);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 23);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";

            // txtEmail
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(40, 196);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 30);
            this.txtEmail.TabIndex = 2;

            // lblAreaTrabalho
            this.lblAreaTrabalho.AutoSize = true;
            this.lblAreaTrabalho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAreaTrabalho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAreaTrabalho.Location = new System.Drawing.Point(40, 250);
            this.lblAreaTrabalho.Name = "lblAreaTrabalho";
            this.lblAreaTrabalho.Size = new System.Drawing.Size(127, 23);
            this.lblAreaTrabalho.TabIndex = 5;
            this.lblAreaTrabalho.Text = "Área de Trabalho:";

            // txtAreaTrabalho
            this.txtAreaTrabalho.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAreaTrabalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAreaTrabalho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAreaTrabalho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAreaTrabalho.Location = new System.Drawing.Point(40, 276);
            this.txtAreaTrabalho.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.txtAreaTrabalho.Name = "txtAreaTrabalho";
            this.txtAreaTrabalho.Size = new System.Drawing.Size(320, 30);
            this.txtAreaTrabalho.TabIndex = 3;

            // btnSalvar
            this.btnSalvar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(40, 340);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 40);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);

            // btnExcluir
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(210, 340);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 40);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "EXCLUIR CONTA";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);

            // panelConta
            this.panelConta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelConta.BackColor = System.Drawing.Color.White;
            this.panelConta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConta.Controls.Add(this.lblTitulo);
            this.panelConta.Controls.Add(this.lblTipo);
            this.panelConta.Controls.Add(this.btnExcluir);
            this.panelConta.Controls.Add(this.lblNome);
            this.panelConta.Controls.Add(this.btnSalvar);
            this.panelConta.Controls.Add(this.txtNome);
            this.panelConta.Controls.Add(this.txtAreaTrabalho);
            this.panelConta.Controls.Add(this.lblEmail);
            this.panelConta.Controls.Add(this.lblAreaTrabalho);
            this.panelConta.Controls.Add(this.txtEmail);
            this.panelConta.Location = new System.Drawing.Point(200, 50);
            this.panelConta.Name = "panelConta";
            this.panelConta.Padding = new System.Windows.Forms.Padding(20);
            this.panelConta.Size = new System.Drawing.Size(400, 420);
            this.panelConta.TabIndex = 8;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(40, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(320, 28);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "MINHA CONTA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // MinhaContaForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelConta);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MinhaContaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minha Conta - Sistema Hospitalar";
            this.Load += new System.EventHandler(this.MinhaContaForm_Load);
            this.panelConta.ResumeLayout(false);
            this.panelConta.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAreaTrabalho;
        private System.Windows.Forms.TextBox txtAreaTrabalho;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panelConta;
        private System.Windows.Forms.Label lblTitulo;
    }
}