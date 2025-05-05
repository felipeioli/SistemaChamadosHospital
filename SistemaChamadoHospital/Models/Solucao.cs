using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaChamadoHospital.Models
{
    public class Solucao
    {


        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataSolucao { get; set; }

        public int IdTecnico { get; set; }

    }
}
