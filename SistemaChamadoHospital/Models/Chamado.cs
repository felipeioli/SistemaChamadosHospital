using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaChamadoHospital.Models
{
    public class Chamado
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Prioridade { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime? DataFechamento { get; set; }

        public int IdUsuario { get; set; }
        public int? IdSolucao { get; set; }
    }
}
