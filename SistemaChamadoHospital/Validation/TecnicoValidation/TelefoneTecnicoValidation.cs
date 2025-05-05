using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Models.Tecnico;

namespace SistemaChamadoHospital.Validation.TecnicoValidation
{
    public class TelefoneTecnicoValidation
    {
        public void Validar(TelefoneTecnico t)
        {
            if (t.Id <= 0)
                throw new ArgumentException("número de telefone é obrigatório.");

            if (string.IsNullOrWhiteSpace(t.Tipo))
                throw new ArgumentException("Tipo de telefone é obrigatório ");

            if (t.IdTecnico <= 0)
                throw new ArgumentException("ID do técnico inválido.");
        }
    }
}
