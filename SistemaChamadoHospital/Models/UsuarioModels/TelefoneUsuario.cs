using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaChamadoHospital.Models.Usuario
{
    public class TelefoneUsuario
    {
        public int Id { get; set; } //telefone usuario
        public string Tipo { get; set; }

        public int IdUsuario { get; set; }
    }
}
