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
    public partial class ListagemChamadoForm : Form
    {
        public ListagemChamadoForm()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new ChamadoService(new ChamadoDao());
                List<Chamado> listaChamados;

                if (Sessao.Tipo == "usuario")
                {
                    listaChamados = service.ListarPorUsuario(Sessao.Id);
                }
                else
                {
                    listaChamados = service.ListarTodos();
                }

                dgvChamados.DataSource = listaChamados;

                if (dgvChamados.Columns.Contains("IdUsuario"))
                    dgvChamados.Columns["IdUsuario"].Visible = false;

                if (dgvChamados.Columns.Contains("IdSolucao"))
                    dgvChamados.Columns["IdSolucao"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chamados: " + ex.Message);
            }
        }

        private void ListagemChamadoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
