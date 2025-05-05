using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Models.Usuario;

namespace SistemaChamadoHospital.Dao.UsuarioDao
{
    public interface ITelefoneUsuarioDao
    {
        void Inserir(TelefoneUsuario telefoneUsuario);
        public List<TelefoneUsuario> ListarTodos();
    }
}
