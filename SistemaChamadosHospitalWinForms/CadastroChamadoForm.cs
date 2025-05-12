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

            cmbPrioridade.Items.Add("Alta");
            cmbPrioridade.Items.Add("Média");
            cmbPrioridade.Items.Add("Baixa");

            panelCadastro.Location = new Point(
            (this.ClientSize.Width - panelCadastro.Width) / 2,
            (this.ClientSize.Height - panelCadastro.Height) / 2
    );
        }

        private void LimparCampos()
        {
            txtDescricao.Clear();
            cmbPrioridade.SelectedIndex = -1;
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {

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
