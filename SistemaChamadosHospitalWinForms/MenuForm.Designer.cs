namespace SistemaChamadoHospitalWinForms
{
    partial class MenuForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastrarChamado = new Button();
            btnListarChamados = new Button();
            btnFecharChamado = new Button();
            SuspendLayout();
            // 
            // btnCadastrarChamado
            // 
            btnCadastrarChamado.Location = new Point(222, 137);
            btnCadastrarChamado.Margin = new Padding(3, 4, 3, 4);
            btnCadastrarChamado.Name = "btnCadastrarChamado";
            btnCadastrarChamado.Size = new Size(299, 55);
            btnCadastrarChamado.TabIndex = 0;
            btnCadastrarChamado.Text = "Cadastro de Chamado";
            btnCadastrarChamado.UseVisualStyleBackColor = true;
            btnCadastrarChamado.Click += btnCadastroChamado_Click;
            // 
            // btnListarChamados
            // 
            btnListarChamados.Location = new Point(222, 245);
            btnListarChamados.Margin = new Padding(3, 4, 3, 4);
            btnListarChamados.Name = "btnListarChamados";
            btnListarChamados.Size = new Size(299, 55);
            btnListarChamados.TabIndex = 1;
            btnListarChamados.Text = "Listar Chamados";
            btnListarChamados.UseVisualStyleBackColor = true;
            btnListarChamados.Click += btnListarChamados_Click;
            // 
            // btnFecharChamado
            // 
            btnFecharChamado.Location = new Point(222, 343);
            btnFecharChamado.Margin = new Padding(3, 4, 3, 4);
            btnFecharChamado.Name = "btnFecharChamado";
            btnFecharChamado.Size = new Size(299, 55);
            btnFecharChamado.TabIndex = 2;
            btnFecharChamado.Text = "Fechar Chamado";
            btnFecharChamado.UseVisualStyleBackColor = true;
            btnFecharChamado.Click += btnFecharChamado_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(btnFecharChamado);
            Controls.Add(btnListarChamados);
            Controls.Add(btnCadastrarChamado);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuForm";
            Text = "Form1";
            Load += MenuForm_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarChamado;
        private System.Windows.Forms.Button btnListarChamados;
        private System.Windows.Forms.Button btnFecharChamado;
    }
}

