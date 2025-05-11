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
            this.lblIdChamado = new System.Windows.Forms.Label();
            this.txtIdChamado = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelFechamento = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelFechamento.SuspendLayout();
            this.SuspendLayout();

            // lblIdChamado
            this.lblIdChamado.AutoSize = true;
            this.lblIdChamado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIdChamado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIdChamado.Location = new System.Drawing.Point(40, 80);
            this.lblIdChamado.Name = "lblIdChamado";
            this.lblIdChamado.Size = new System.Drawing.Size(120, 23);
            this.lblIdChamado.TabIndex = 0;
            this.lblIdChamado.Text = "ID do Chamado:";

            // txtIdChamado
            this.txtIdChamado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIdChamado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdChamado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIdChamado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdChamado.Location = new System.Drawing.Point(40, 106);
            this.txtIdChamado.Name = "txtIdChamado";
            this.txtIdChamado.Size = new System.Drawing.Size(200, 30);
            this.txtIdChamado.TabIndex = 1;

            // btnFechar
            this.btnFechar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(40, 160);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(200, 40);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "FECHAR CHAMADO";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);

            // panelFechamento
            this.panelFechamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelFechamento.BackColor = System.Drawing.Color.White;
            this.panelFechamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFechamento.Controls.Add(this.lblTitulo);
            this.panelFechamento.Controls.Add(this.lblIdChamado);
            this.panelFechamento.Controls.Add(this.btnFechar);
            this.panelFechamento.Controls.Add(this.txtIdChamado);
            this.panelFechamento.Location = new System.Drawing.Point(200, 50);
            this.panelFechamento.Name = "panelFechamento";
            this.panelFechamento.Padding = new System.Windows.Forms.Padding(20);
            this.panelFechamento.Size = new System.Drawing.Size(400, 250);
            this.panelFechamento.TabIndex = 3;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(40, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(320, 28);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "FECHAMENTO DE CHAMADO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // FechamentoChamadoForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.panelFechamento);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "FechamentoChamadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechamento de Chamado - Sistema Hospitalar";
            this.panelFechamento.ResumeLayout(false);
            this.panelFechamento.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblIdChamado;
        private System.Windows.Forms.TextBox txtIdChamado;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panelFechamento;
        private System.Windows.Forms.Label lblTitulo;
    }
}