using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Dao;
using SistemaChamadoHospital.Validation;

namespace SistemaChamadoHospital.Service
{
    public class SetorService
    {
        private ISetorDao _setorDao;
        private SetorValidation _setorValidation;
        public SetorService(ISetorDao setorDao)
        {
            _setorDao = setorDao;
            _setorValidation = new SetorValidation();
        }
        public void Inserir(string nome, string local)
        {
            var setor = new Models.Setor
            {
                Nome = nome,
                Local = local
            };
            _setorValidation.Validar(setor);
            _setorDao.Inserir(setor);
        }
        public List<Models.Setor> ListarTodos()
        {
            return _setorDao.ListarTodos();
        }
    }
}
