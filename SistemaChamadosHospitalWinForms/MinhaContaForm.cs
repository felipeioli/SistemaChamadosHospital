using SistemaChamadoHospital.Models;
using SistemaChamadoHospital.Service;
using SistemaChamadoHospitalPostgres.DaoPostgres;
using System;
using System.Windows.Forms;

namespace SistemaChamadoHospitalWinForms
{
    public partial class MinhaContaForm : Form
    {
        private UsuarioService _usuarioService;

        public MinhaContaForm()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService(new UsuarioDao());
        }

        private void MinhaContaForm_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            if (Sessao.Tipo == "usuario")
            {
                var usuario = new UsuarioService(new UsuarioDao()).ObterPorId(Sessao.Id);
                if (usuario != null)
                {
                    txtNome.Text = usuario.Nome;
                    txtEmail.Text = usuario.Email;
                    txtAreaTrabalho.Text = usuario.AreaTrabalho;
                    lblTipo.Text = "Tipo: Usuário";
                }
            }
            else if (Sessao.Tipo == "tecnico")
            {
                var tecnico = new TecnicoService(new TecnicoDao()).ObterPorId(Sessao.Id);
                if (tecnico != null)
                {
                    txtNome.Text = tecnico.Nome;
                    txtEmail.Text = tecnico.Email;
                    txtAreaTrabalho.Text = "";
                    lblTipo.Text = "Tipo: Técnico";
                    txtAreaTrabalho.Visible = false;
                    lblAreaTrabalho.Visible = false;
                }
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = new Usuario
                {
                    Id = Sessao.Id,
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    AreaTrabalho = txtAreaTrabalho.Text
                };

                _usuarioService.Atualizar(usuario);
                MessageBox.Show("Dados atualizados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Tem certeza que deseja excluir sua conta?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _usuarioService.Deletar(Sessao.Id);
                    MessageBox.Show("Conta excluída!");
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message);
                }
            }
        }
    }
}
