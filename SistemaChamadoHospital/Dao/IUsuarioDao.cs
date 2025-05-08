using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Models;

namespace SistemaChamadoHospital.Dao
{
    public interface IUsuarioDao
    {
        public void Inserir(Usuario u);
        public List<Usuario> ListarTodos();
    }
}
