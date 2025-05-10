using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaChamadosHospitalWinForms;

namespace SistemaChamadoHospitalWinForms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnCadastrarChamado_Click(object sender, EventArgs e)
        {
            var form = new CadastroChamadoForm();
            form.ShowDialog();
        }

        private void btnListarChamados_Click(object sender, EventArgs e)
        {
            var form = new ListagemChamadoForm();
            form.ShowDialog();
        }

        private void btnFecharChamado_Click(object sender, EventArgs e)
        {
            var form = new FechamentoChamadoForm();
            form.ShowDialog();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            if (Sessao.Tipo == "usuario")
            {
                btnCadastrarChamado.Visible = true;
                btnFecharChamado.Visible = false;
            }
            else if (Sessao.Tipo == "tecnico")
            {
                btnCadastrarChamado.Visible = false;
                btnFecharChamado.Visible = true;
            }
        }
    }
}
