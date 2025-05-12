using System;
using System.Windows.Forms;
using SistemaChamadoHospital.Models;
using SistemaChamadoHospital.Service;
using SistemaChamadoHospitalPostgres.DaoPostgres;
using SistemaChamadoHospital.Utils;

namespace SistemaChamadoHospitalWinForms
{
    public partial class CadastroForm : Form
    {
        private UsuarioService _usuarioService;
        private TecnicoService _tecnicoService;

        public CadastroForm()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService(new UsuarioDao());
            _tecnicoService = new TecnicoService(new TecnicoDao());
        }

        private void CadastroForm_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Usuário");
            cmbTipo.Items.Add("Técnico");

            txtAreaTrabalho.Visible = false;
            lblAreaTrabalho.Visible = false;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbTipo.SelectedItem?.ToString();
            bool mostrar = tipo == "Usuário";

            txtAreaTrabalho.Visible = mostrar;
            lblAreaTrabalho.Visible = mostrar;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();
            string tipo = cmbTipo.SelectedItem?.ToString();
            string areaTrabalho = txtAreaTrabalho.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(tipo))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            string senhaHash = SenhaUtil.GerarHash(senha);

            try
            {
                if (tipo == "Usuário")
                {
                    if (string.IsNullOrWhiteSpace(areaTrabalho))
                    {
                        MessageBox.Show("Preencha a Área de Trabalho.");
                        return;
                    }

                    _usuarioService.Inserir(new Usuario
                    {
                        Nome = nome,
                        Email = email,
                        Senha = senhaHash,
                        AreaTrabalho = areaTrabalho
                    });
                }
                else
                {
                    _tecnicoService.Inserir(new Tecnico
                    {
                        Nome = nome,
                        Email = email,
                        Senha = senhaHash
                    });
                }

                MessageBox.Show($"{tipo} cadastrado com sucesso!");
                new LoginForm().Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }

        private void lklTelaLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
