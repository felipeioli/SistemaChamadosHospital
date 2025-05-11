namespace SistemaChamadoHospitalWinForms
{
    partial class MenuForm
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
            this.btnCadastrarChamado = new System.Windows.Forms.Button();
            this.btnListarChamados = new System.Windows.Forms.Button();
            this.btnFecharChamado = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();

            // btnCadastrarChamado
            this.btnCadastrarChamado.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCadastrarChamado.FlatAppearance.BorderSize = 0;
            this.btnCadastrarChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarChamado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarChamado.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarChamado.Location = new System.Drawing.Point(50, 100);
            this.btnCadastrarChamado.Name = "btnCadastrarChamado";
            this.btnCadastrarChamado.Size = new System.Drawing.Size(300, 50);
            this.btnCadastrarChamado.TabIndex = 0;
            this.btnCadastrarChamado.Text = "CADASTRAR CHAMADO";
            this.btnCadastrarChamado.UseVisualStyleBackColor = false;
            this.btnCadastrarChamado.Click += new System.EventHandler(this.btnCadastrarChamado_Click);

            // btnListarChamados
            this.btnListarChamados.BackColor = System.Drawing.Color.SteelBlue;
            this.btnListarChamados.FlatAppearance.BorderSize = 0;
            this.btnListarChamados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarChamados.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListarChamados.ForeColor = System.Drawing.Color.White;
            this.btnListarChamados.Location = new System.Drawing.Point(50, 180);
            this.btnListarChamados.Name = "btnListarChamados";
            this.btnListarChamados.Size = new System.Drawing.Size(300, 50);
            this.btnListarChamados.TabIndex = 1;
            this.btnListarChamados.Text = "LISTAR CHAMADOS";
            this.btnListarChamados.UseVisualStyleBackColor = false;
            this.btnListarChamados.Click += new System.EventHandler(this.btnListarChamados_Click);

            // btnFecharChamado
            this.btnFecharChamado.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFecharChamado.FlatAppearance.BorderSize = 0;
            this.btnFecharChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharChamado.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFecharChamado.ForeColor = System.Drawing.Color.White;
            this.btnFecharChamado.Location = new System.Drawing.Point(50, 260);
            this.btnFecharChamado.Name = "btnFecharChamado";
            this.btnFecharChamado.Size = new System.Drawing.Size(300, 50);
            this.btnFecharChamado.TabIndex = 2;
            this.btnFecharChamado.Text = "FECHAR CHAMADO";
            this.btnFecharChamado.UseVisualStyleBackColor = false;
            this.btnFecharChamado.Click += new System.EventHandler(this.btnFecharChamado_Click);

            // panelMenu
            this.panelMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.lblTitulo);
            this.panelMenu.Controls.Add(this.btnCadastrarChamado);
            this.panelMenu.Controls.Add(this.btnFecharChamado);
            this.panelMenu.Controls.Add(this.btnListarChamados);
            this.panelMenu.Location = new System.Drawing.Point(200, 50);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(20);
            this.panelMenu.Size = new System.Drawing.Size(400, 400);
            this.panelMenu.TabIndex = 3;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(50, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 28);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "MENU PRINCIPAL";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // MenuForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Sistema Hospitalar";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarChamado;
        private System.Windows.Forms.Button btnListarChamados;
        private System.Windows.Forms.Button btnFecharChamado;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblTitulo;
    }
}