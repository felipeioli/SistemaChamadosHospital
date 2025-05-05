using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Models.Tecnico;

namespace SistemaChamadoHospital.Dao.TecnicoDao
{
    public interface ITecnicoDao
    {
        void Inserir(Tecnico tecnico);
        public List<Tecnico> ListarTodos();
    }
}
