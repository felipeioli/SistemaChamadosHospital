﻿using System;
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
    public partial class FechamentoChamadoForm : Form
    {
        public FechamentoChamadoForm()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                int idChamado = int.Parse(txtIdChamado.Text);
                var service = new ChamadoService(new ChamadoDao());
                service.AtualizarStatusFechamento(idChamado, DateTime.Now);
                MessageBox.Show("Chamado fechado com sucesso!");
                txtIdChamado.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar chamado: " + ex.Message);
            }
        }

    }
}
