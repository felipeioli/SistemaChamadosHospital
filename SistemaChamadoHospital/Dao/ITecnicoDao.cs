using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Models;

namespace SistemaChamadoHospital.Dao
{
    public interface ITecnicoDao
    {
        void Inserir(Tecnico tecnico);
        public List<Tecnico> ListarTodos();
    }
}