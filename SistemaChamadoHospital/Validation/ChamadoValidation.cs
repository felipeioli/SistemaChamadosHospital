using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Models;

namespace SistemaChamadoHospital.Validation
{
    public class ChamadoValidation
    {
        public void Validar(Chamado c)
        {
            if (string.IsNullOrWhiteSpace(c.Status))
                throw new ArgumentException("Status é obrigatório.");

            if (string.IsNullOrWhiteSpace(c.Prioridade))
                throw new ArgumentException("Prioridade é obrigatória.");

            if (string.IsNullOrWhiteSpace(c.Descricao))
                throw new ArgumentException("Descrição é obrigatória.");

            if (c.DataAbertura == DateTime.MinValue)
                throw new ArgumentException("Data de abertura inválida.");

            if (c.IdUsuario <= 0)
                throw new ArgumentException("ID do usuário inválido.");
        }
    }

}
