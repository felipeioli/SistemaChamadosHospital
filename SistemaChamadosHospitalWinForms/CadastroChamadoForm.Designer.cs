namespace SistemaChamadoHospitalWinForms
{
    partial class CadastroChamadoForm
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.cmbPrioridade = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelCadastro.SuspendLayout();
            this.SuspendLayout();

            // lblDescricao
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescricao.Location = new System.Drawing.Point(30, 80);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 23);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição:";

            // txtDescricao
            this.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescricao.Location = new System.Drawing.Point(30, 106);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(340, 100);
            this.txtDescricao.TabIndex = 1;

            // lblPrioridade
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrioridade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrioridade.Location = new System.Drawing.Point(30, 230);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(84, 23);
            this.lblPrioridade.TabIndex = 2;
            this.lblPrioridade.Text = "Prioridade:";

            // cmbPrioridade
            this.cmbPrioridade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPrioridade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPrioridade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbPrioridade.FormattingEnabled = true;
            this.cmbPrioridade.Location = new System.Drawing.Point(30, 256);
            this.cmbPrioridade.Name = "cmbPrioridade";
            this.cmbPrioridade.Size = new System.Drawing.Size(200, 31);
            this.cmbPrioridade.TabIndex = 2;

            // btnCadastrar
            this.btnCadastrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(30, 320);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(200, 40);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);

            // panelCadastro
            this.panelCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCadastro.BackColor = System.Drawing.Color.White;
            this.panelCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCadastro.Controls.Add(this.lblTitulo);
            this.panelCadastro.Controls.Add(this.lblDescricao);
            this.panelCadastro.Controls.Add(this.btnCadastrar);
            this.panelCadastro.Controls.Add(this.txtDescricao);
            this.panelCadastro.Controls.Add(this.cmbPrioridade);
            this.panelCadastro.Controls.Add(this.lblPrioridade);
            this.panelCadastro.Location = new System.Drawing.Point(200, 50);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Padding = new System.Windows.Forms.Padding(20);
            this.panelCadastro.Size = new System.Drawing.Size(400, 400);
            this.panelCadastro.TabIndex = 5;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(340, 28);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "CADASTRO DE NOVO CHAMADO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // CadastroChamadoForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelCadastro);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "CadastroChamadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Chamado - Sistema Hospitalar";
            this.Load += new System.EventHandler(this.CadastroChamadoForm_Load);
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.ComboBox cmbPrioridade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panelCadastro;
        private System.Windows.Forms.Label lblTitulo;
    }
}