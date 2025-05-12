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
            btnCadastrarChamado = new Button();
            btnListarChamados = new Button();
            btnFecharChamado = new Button();
            panelMenu = new Panel();
            btnMinhaConta = new Button();
            lblTitulo = new Label();
            panel1 = new Panel();
            panelConteudo = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnCadastrarChamado
            // 
            btnCadastrarChamado.BackColor = Color.FromArgb(52, 73, 94);
            btnCadastrarChamado.FlatAppearance.BorderSize = 0;
            btnCadastrarChamado.FlatStyle = FlatStyle.Flat;
            btnCadastrarChamado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCadastrarChamado.ForeColor = Color.White;
            btnCadastrarChamado.Location = new Point(-1, 153);
            btnCadastrarChamado.Margin = new Padding(0);
            btnCadastrarChamado.Name = "btnCadastrarChamado";
            btnCadastrarChamado.Size = new Size(414, 129);
            btnCadastrarChamado.TabIndex = 0;
            btnCadastrarChamado.Text = "CADASTRAR CHAMADO";
            btnCadastrarChamado.UseVisualStyleBackColor = false;
            btnCadastrarChamado.Click += btnCadastrarChamado_Click;
            // 
            // btnListarChamados
            // 
            btnListarChamados.BackColor = Color.FromArgb(52, 73, 94);
            btnListarChamados.FlatAppearance.BorderSize = 0;
            btnListarChamados.FlatStyle = FlatStyle.Flat;
            btnListarChamados.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnListarChamados.ForeColor = Color.White;
            btnListarChamados.Location = new Point(-1, 282);
            btnListarChamados.Name = "btnListarChamados";
            btnListarChamados.Size = new Size(414, 129);
            btnListarChamados.TabIndex = 1;
            btnListarChamados.Text = "LISTAR CHAMADOS";
            btnListarChamados.UseVisualStyleBackColor = false;
            btnListarChamados.Click += btnListarChamados_Click;
            // 
            // btnFecharChamado
            // 
            btnFecharChamado.BackColor = Color.FromArgb(52, 73, 94);
            btnFecharChamado.FlatAppearance.BorderSize = 0;
            btnFecharChamado.FlatStyle = FlatStyle.Flat;
            btnFecharChamado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnFecharChamado.ForeColor = Color.White;
            btnFecharChamado.Location = new Point(-1, 411);
            btnFecharChamado.Name = "btnFecharChamado";
            btnFecharChamado.Size = new Size(414, 129);
            btnFecharChamado.TabIndex = 2;
            btnFecharChamado.Text = "FECHAR CHAMADO";
            btnFecharChamado.UseVisualStyleBackColor = false;
            btnFecharChamado.Click += btnFecharChamado_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(44, 62, 80);
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(btnMinhaConta);
            panelMenu.Controls.Add(btnFecharChamado);
            panelMenu.Controls.Add(lblTitulo);
            panelMenu.Controls.Add(btnListarChamados);
            panelMenu.Controls.Add(btnCadastrarChamado);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Padding = new Padding(20);
            panelMenu.Size = new Size(414, 668);
            panelMenu.TabIndex = 3;
            // 
            // btnMinhaConta
            // 
            btnMinhaConta.BackColor = Color.FromArgb(52, 73, 94);
            btnMinhaConta.FlatAppearance.BorderSize = 0;
            btnMinhaConta.FlatStyle = FlatStyle.Flat;
            btnMinhaConta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnMinhaConta.ForeColor = Color.White;
            btnMinhaConta.Location = new Point(-1, 534);
            btnMinhaConta.Name = "btnMinhaConta";
            btnMinhaConta.Size = new Size(414, 129);
            btnMinhaConta.TabIndex = 2;
            btnMinhaConta.Text = "MINHA CONTA";
            btnMinhaConta.UseVisualStyleBackColor = false;
            btnMinhaConta.Click += btnMinhaConta_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(107, 42);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(178, 28);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "MENU PRINCIPAL";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 133);
            panel1.TabIndex = 4;
            // 
            // panelConteudo
            // 
            panelConteudo.BackColor = Color.White;
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(414, 0);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(848, 668);
            panelConteudo.TabIndex = 4;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 250);
            ClientSize = new Size(1262, 668);
            Controls.Add(panelConteudo);
            Controls.Add(panelMenu);
            MinimumSize = new Size(600, 400);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu - Sistema Chamado";
            Load += MenuForm_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarChamado;
        private System.Windows.Forms.Button btnListarChamados;
        private System.Windows.Forms.Button btnFecharChamado;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblTitulo;
        private Panel panelConteudo;
        private Button btnMinhaConta;
        private Panel panel1;
    }
}