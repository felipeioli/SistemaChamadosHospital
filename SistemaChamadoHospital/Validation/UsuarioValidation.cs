using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Models;

namespace SistemaChamadoHospital.Validation
{
    public class UsuarioValidation
    {
        public void Validar(Usuario u)
        {
            if (string.IsNullOrWhiteSpace(u.Nome))
                throw new ArgumentException("Nome é obrigatório.");

            if (string.IsNullOrWhiteSpace(u.Email))
                throw new ArgumentException("Email é obrigatório.");
        }
    }

}
