namespace SistemaChamadoHospitalWinForms
{
    partial class FechamentoChamadoForm
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
            lblIdChamado = new Label();
            txtIdChamado = new TextBox();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // lblIdChamado
            // 
            lblIdChamado.AutoSize = true;
            lblIdChamado.Location = new Point(346, 59);
            lblIdChamado.Name = "lblIdChamado";
            lblIdChamado.Size = new Size(117, 20);
            lblIdChamado.TabIndex = 0;
            lblIdChamado.Text = "ID do Chamado:";
            // 
            // txtIdChamado
            // 
            txtIdChamado.Location = new Point(336, 82);
            txtIdChamado.Name = "txtIdChamado";
            txtIdChamado.Size = new Size(138, 27);
            txtIdChamado.TabIndex = 1;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(336, 115);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(138, 29);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "Fechar Chamado\n\n";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FechamentoChamadoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFechar);
            Controls.Add(txtIdChamado);
            Controls.Add(lblIdChamado);
            Name = "FechamentoChamadoForm";
            Text = "Tela de Fechar Chamado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdChamado;
        private TextBox txtIdChamado;
        private Button btnFechar;
    }
}