using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Models;
using SistemaChamadoHospital.Models.Usuario;

namespace SistemaChamadoHospital.Dao.UsuarioDao
{
    public interface IUsuarioDao
    {
        public void Inserir(Usuario u);
        public List<Usuario> ListarTodos();
    }
}
