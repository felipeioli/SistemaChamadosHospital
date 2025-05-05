using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Models;

namespace SistemaChamadoHospital.Validation
{
    public class SetorValidation
    {
        public void Validar(Setor s)
        {
            if (string.IsNullOrWhiteSpace(s.Nome))
                throw new ArgumentException("Nome é obrigatório.");
            if (string.IsNullOrWhiteSpace(s.Local))
                throw new ArgumentException("Local é obrigatório.");
        }
    }
}
