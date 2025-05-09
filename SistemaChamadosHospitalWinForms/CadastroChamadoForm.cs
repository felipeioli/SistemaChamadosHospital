using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
