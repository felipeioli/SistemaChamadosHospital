using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaChamadoHospital.Models;
using SistemaChamadoHospital.Service;
using SistemaChamadoHospitalPostgres.DaoPostgres;

namespace SistemaChamadoHospitalWinForms
{
    public partial class CadastroChamadoForm : Form
    {
        public CadastroChamadoForm()
        {
            InitializeComponent();
        }

        private void CadastroChamadoForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ID logado: " + Sessao.Id);


            cmbPrioridade.Items.Add("Alta");
            cmbPrioridade.Items.Add("Média");
            cmbPrioridade.Items.Add("Baixa");
        }

        private void LimparCampos()
        {
            txtDescricao.Clear();
            cmbPrioridade.SelectedIndex = -1;
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sessão.Id no CadastroChamadoForm: " + Sessao.Id);

            try
            {
                var chamado = new Chamado
                {
                    Status = "Aberto",
                    Prioridade = cmbPrioridade.SelectedItem?.ToString(),
                    Descricao = txtDescricao.Text,
                    DataAbertura = DateTime.Now,
                    IdUsuario = Sessao.Id,
                };

                var service = new ChamadoService(new ChamadoDao());
                service.AbrirChamado(chamado);

                MessageBox.Show("Chamado cadastrado com sucesso!");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
