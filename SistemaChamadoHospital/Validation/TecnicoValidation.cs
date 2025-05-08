using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Models;

namespace SistemaChamadoHospital.Validation
{
    public class TecnicoValidation
    {
        public void Validar(Tecnico t)
        {
            if (string.IsNullOrWhiteSpace(t.Nome))
                throw new ArgumentException("Nome é obrigatório.");

            if (string.IsNullOrWhiteSpace(t.Especialidade))
                throw new ArgumentException("Especialidade é obrigatória.");
        }
    }
}
