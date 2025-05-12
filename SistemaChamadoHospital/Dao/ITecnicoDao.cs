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
        Tecnico ObterPorId(int id);
        void Atualizar(Tecnico tecnico);
        void Deletar(int id);
        Tecnico ObterPorEmailESenha(string email, string senhaHash);
    }
}