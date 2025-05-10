using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaChamadoHospital.Service;
using SistemaChamadoHospitalPostgres.DaoPostgres;
using SistemaChamadoHospital.Models;


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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string tipo = cmbTipo.SelectedItem?.ToString();
            string areaTrabalho = txtAreaTrabalho.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(tipo))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            if (tipo == "Usuário" && string.IsNullOrWhiteSpace(areaTrabalho))
            {
                MessageBox.Show("Preencha o campo Área de Trabalho.");
                return;
            }

            try
            {
                if (tipo == "Usuário")
                {
                    _usuarioService.Inserir(new Usuario
                    {
                        Nome = nome,
                        Email = email,
                        AreaTrabalho = areaTrabalho
                    });
                }
                else
                {
                    _tecnicoService.Inserir(new Tecnico
                    {
                        Nome = nome,
                        Email = email
                    });
                }

                MessageBox.Show($"{tipo} cadastrado com sucesso!");
                this.Hide();
                LoginForm login = new LoginForm();
                login.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbTipo.SelectedItem?.ToString();

            bool mostrarAreaTrabalho = tipo == "Usuário";

            txtAreaTrabalho.Visible = mostrarAreaTrabalho;
            lblAreaTrabalho.Visible = mostrarAreaTrabalho;
        }

        private void lklTelaLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}

