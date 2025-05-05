using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Models.Tecnico;

namespace SistemaChamadoHospital.Dao.TecnicoDao
{
    public interface ITelefoneTecnicoDao
    {
        void Inserir(TelefoneTecnico telefoneTecnico);
        public List<TelefoneTecnico> ListarTodos();
    }
}
