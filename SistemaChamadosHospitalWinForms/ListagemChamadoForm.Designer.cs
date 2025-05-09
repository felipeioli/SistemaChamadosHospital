namespace SistemaChamadoHospitalWinForms
{
    partial class ListagemChamadoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvChamados = new DataGridView();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChamados).BeginInit();
            SuspendLayout();
            // 
            // dgvChamados
            // 
            dgvChamados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamados.Location = new Point(33, 30);
            dgvChamados.Margin = new Padding(3, 4, 3, 4);
            dgvChamados.Name = "dgvChamados";
            dgvChamados.RowHeadersWidth = 51;
            dgvChamados.RowTemplate.Height = 24;
            dgvChamados.Size = new Size(736, 319);
            dgvChamados.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(307, 378);
            btnAtualizar.Margin = new Padding(3, 4, 3, 4);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(148, 54);
            btnAtualizar.TabIndex = 1;
            btnAtualizar.Text = "Atualizar lista";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // ListagemChamadoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(btnAtualizar);
            Controls.Add(dgvChamados);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ListagemChamadoForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvChamados).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChamados;
        private System.Windows.Forms.Button btnAtualizar;
    }
}