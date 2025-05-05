using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Models;

namespace SistemaChamadoHospital.Dao
{
    public interface ISetorDao
    {
        void Inserir(Setor setor);
        public List<Setor> ListarTodos();
    }
}
