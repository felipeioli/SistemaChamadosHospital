namespace SistemaChamadoHospitalWinForms
{
    partial class LoginForm
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
            lblEmail = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            cmbTipo = new ComboBox();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(372, 67);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(293, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 27);
            txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 170);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 2;
            label2.Text = "Tipo de Acesso:";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(293, 193);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(213, 28);
            cmbTipo.TabIndex = 3;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(356, 265);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(94, 29);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEntrar);
            Controls.Add(cmbTipo);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Name = "LoginForm";
            Text = "Form1";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private TextBox txtEmail;
        private Label label2;
        private ComboBox cmbTipo;
        private Button btnEntrar;
    }
}