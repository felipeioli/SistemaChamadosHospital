using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Models.Usuario;

namespace SistemaChamadoHospital.Validation.UsuarioValidation
{
    public class TelefoneUsuarioValidation
    {
        public void Validar(TelefoneUsuario t)
        {
            if (t.Id <= 0)
                throw new ArgumentException("Número de telefone é obrigatório.");

            if (string.IsNullOrWhiteSpace(t.Tipo))
                throw new ArgumentException("Tipo de telefone é obrigatório.");

            if (t.IdUsuario <= 0)
                throw new ArgumentException("ID do usuário inválido.");
        }
    }
}
