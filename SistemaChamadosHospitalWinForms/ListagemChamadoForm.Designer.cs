namespace SistemaChamadoHospitalWinForms
{
    partial class ListagemChamadoForm
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
            this.dgvChamados = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.panelListagem = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamados)).BeginInit();
            this.panelListagem.SuspendLayout();
            this.SuspendLayout();

            // dgvChamados
            this.dgvChamados.AllowUserToAddRows = false;
            this.dgvChamados.AllowUserToDeleteRows = false;
            this.dgvChamados.BackgroundColor = System.Drawing.Color.White;
            this.dgvChamados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvChamados.Location = new System.Drawing.Point(30, 70);
            this.dgvChamados.Name = "dgvChamados";
            this.dgvChamados.ReadOnly = true;
            this.dgvChamados.RowHeadersWidth = 51;
            this.dgvChamados.RowTemplate.Height = 29;
            this.dgvChamados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChamados.Size = new System.Drawing.Size(740, 350);
            this.dgvChamados.TabIndex = 0;

            // btnAtualizar
            this.btnAtualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(300, 440);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(200, 50);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "ATUALIZAR LISTA";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);

            // panelListagem
            this.panelListagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelListagem.BackColor = System.Drawing.Color.White;
            this.panelListagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelListagem.Controls.Add(this.lblTitulo);
            this.panelListagem.Controls.Add(this.dgvChamados);
            this.panelListagem.Controls.Add(this.btnAtualizar);
            this.panelListagem.Location = new System.Drawing.Point(25, 25);
            this.panelListagem.Name = "panelListagem";
            this.panelListagem.Padding = new System.Windows.Forms.Padding(20);
            this.panelListagem.Size = new System.Drawing.Size(800, 520);
            this.panelListagem.TabIndex = 2;

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(240, 28);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "LISTAGEM DE CHAMADOS";

            // ListagemChamadoForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(850, 570);
            this.Controls.Add(this.panelListagem);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "ListagemChamadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Chamados - Sistema Hospitalar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamados)).EndInit();
            this.panelListagem.ResumeLayout(false);
            this.panelListagem.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChamados;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Panel panelListagem;
        private System.Windows.Forms.Label lblTitulo;
    }
}