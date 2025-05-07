using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Models;

namespace SistemaChamadoHospital.Validation
{
    public class SolucaoValidation
    {
        public void Validar(Solucao s)
        {
        if (string.IsNullOrWhiteSpace(s.Descricao))
            throw new ArgumentException("Descricao é obrigatório.");

        if (s.DataSolucao == DateTime.MinValue)
            throw new ArgumentException("Data de resolução inválida.");

        if (s.IdTecnico <= 0)
            throw new ArgumentException("ID do técnico inválido.");
        }
    }
}


