using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Models;

namespace SistemaChamadoHospital.Dao
{
    public interface IChamadoDao
    {

        void Inserir(Chamado chamado);
        List<Chamado> ListarTodos();
    }
}
