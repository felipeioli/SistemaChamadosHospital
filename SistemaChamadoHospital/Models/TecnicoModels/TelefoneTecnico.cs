using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaChamadoHospital.Models.Tecnico
{
    public class TelefoneTecnico
    {
        public int Id { get; set; } // telefone tecnico
        public string Tipo { get; set; }

        public int IdTecnico { get; set; }
    }
}
