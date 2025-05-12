namespace SistemaChamadoHospitalWinForms
{
    partial class FechamentoChamadoForm
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
            lblIdChamado = new Label();
            txtIdChamado = new TextBox();
            btnFechar = new Button();
            panelFechamento = new Panel();
            lblTitulo = new Label();
            panelFechamento.SuspendLayout();
            SuspendLayout();
            // 
            // lblIdChamado
            // 
            lblIdChamado.AutoSize = true;
            lblIdChamado.Font = new Font("Segoe UI", 10F);
            lblIdChamado.ForeColor = Color.FromArgb(64, 64, 64);
            lblIdChamado.Location = new Point(40, 80);
            lblIdChamado.Name = "lblIdChamado";
            lblIdChamado.Size = new Size(135, 23);
            lblIdChamado.TabIndex = 0;
            lblIdChamado.Text = "ID do Chamado:";
            // 
            // txtIdChamado
            // 
            txtIdChamado.BackColor = Color.WhiteSmoke;
            txtIdChamado.BorderStyle = BorderStyle.FixedSingle;
            txtIdChamado.Font = new Font("Segoe UI", 10F);
            txtIdChamado.ForeColor = Color.FromArgb(64, 64, 64);
            txtIdChamado.Location = new Point(40, 106);
            txtIdChamado.Name = "txtIdChamado";
            txtIdChamado.Size = new Size(200, 30);
            txtIdChamado.TabIndex = 1;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(52, 73, 94);
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(40, 160);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(200, 40);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "FECHAR CHAMADO";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // panelFechamento
            // 
            panelFechamento.Anchor = AnchorStyles.None;
            panelFechamento.BackColor = Color.White;
            panelFechamento.BorderStyle = BorderStyle.FixedSingle;
            panelFechamento.Controls.Add(lblTitulo);
            panelFechamento.Controls.Add(lblIdChamado);
            panelFechamento.Controls.Add(btnFechar);
            panelFechamento.Controls.Add(txtIdChamado);
            panelFechamento.Location = new Point(431, 246);
            panelFechamento.Name = "panelFechamento";
            panelFechamento.Padding = new Padding(20);
            panelFechamento.Size = new Size(400, 250);
            panelFechamento.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(40, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(288, 28);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "FECHAMENTO DE CHAMADO";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FechamentoChamadoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 245, 250);
            ClientSize = new Size(1262, 743);
            Controls.Add(panelFechamento);
            MinimumSize = new Size(600, 300);
            Name = "FechamentoChamadoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fechamento de Chamado - Sistema Chamado";
            panelFechamento.ResumeLayout(false);
            panelFechamento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblIdChamado;
        private System.Windows.Forms.TextBox txtIdChamado;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panelFechamento;
        private System.Windows.Forms.Label lblTitulo;
    }
}