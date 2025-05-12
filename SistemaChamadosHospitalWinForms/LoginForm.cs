using System;
using System.Linq;
using System.Windows.Forms;
using SistemaChamadoHospital.Service;
using SistemaChamadoHospitalPostgres.DaoPostgres;
using SistemaChamadoHospital.Utils;

namespace SistemaChamadoHospitalWinForms
{
    public partial class LoginForm : Form
    {
        private UsuarioService _usuarioService;
        private TecnicoService _tecnicoService;

        public LoginForm()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService(new UsuarioDao());
            _tecnicoService = new TecnicoService(new TecnicoDao());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Usuário");
            cmbTipo.Items.Add("Técnico");
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text;
            string tipo = cmbTipo.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(tipo))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            string senhaHash = SenhaUtil.GerarHash(senha);

            if (tipo == "Usuário")
            {

                var usuario = _usuarioService.ObterPorEmailESenha(email, senhaHash);
                
                if (usuario != null)
                {
                    Sessao.Id = usuario.Id;
                    Sessao.Nome = usuario.Nome;
                    Sessao.Tipo = "usuario";
                    new MenuForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.");
                }
            }
            else if (tipo == "Técnico")
            {
                var tecnico = _tecnicoService.ObterPorEmailESenha(email, senhaHash);
                if (tecnico != null)
                {
                    Sessao.Id = tecnico.Id;
                    Sessao.Nome = tecnico.Nome;
                    Sessao.Tipo = "tecnico";
                    new MenuForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Técnico ou senha inválidos.");
                }
            }
        }


        private void lklRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CadastroForm().Show();
            this.Hide();
        }
    }
}
