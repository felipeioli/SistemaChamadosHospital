using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaChamadoHospital.Service;
using SistemaChamadoHospitalPostgres.DaoPostgres;

namespace SistemaChamadoHospitalWinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Usuário");
            cmbTipo.Items.Add("Técnico");
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string tipo = cmbTipo.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(tipo))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            if (tipo == "Usuário")
            {
                var usuarios = new UsuarioService(new UsuarioDao()).ListarTodos();
                var usuario = usuarios.FirstOrDefault(u => u.Email == email);
                if (usuario != null)
                {
                    Sessao.Id = usuario.Id;
                    Sessao.Nome = usuario.Nome;
                    Sessao.Tipo = "usuario";

                    this.Hide();
                    MessageBox.Show($"Bem-vindo, {usuario.Nome}!");
                    new MenuForm().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado.");
                }
            }
            else if (tipo == "Técnico")
            {
                var tecnicos = new TecnicoService(new TecnicoDao()).ListarTodos();
                var tecnico = tecnicos.FirstOrDefault(t => t.Email.ToLower() == email.ToLower());
                if (tecnico != null)
                {
                    Sessao.Id = tecnico.Id;
                    Sessao.Nome = tecnico.Nome;
                    Sessao.Tipo = "tecnico";

                    this.Hide();
                    MessageBox.Show($"Bem-vindo, técnico {tecnico.Nome}!");
                    new MenuForm().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Técnico não encontrado.");
                }
            }
        }

        private void lklRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroForm formCadastro = new CadastroForm();
            formCadastro.ShowDialog();
            this.Hide();
        }
    }
}
