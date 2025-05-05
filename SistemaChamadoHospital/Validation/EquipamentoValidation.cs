using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Models;

namespace SistemaChamadoHospital.Validation
{
    public class EquipamentoValidation
    {
        public void Validar(Equipamento e)
        {
            if (string.IsNullOrWhiteSpace(e.Nome))
                throw new ArgumentException("Nome é obrigatório.");

            if (string.IsNullOrWhiteSpace(e.Modelo))
                throw new ArgumentException("Modelo é obrigatório.");
        }
    }
}
