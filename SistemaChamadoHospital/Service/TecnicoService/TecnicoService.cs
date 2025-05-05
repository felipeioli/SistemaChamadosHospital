using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Dao.TecnicoDao;
using SistemaChamadoHospital.Validation.TecnicoValidation;

namespace SistemaChamadoHospital.Service.TecnicoService
{
    public class TecnicoService
    {
        private ITecnicoDao _tecnicoDao;
        private TecnicoValidation _tecnicoValidation;

        public TecnicoService(ITecnicoDao tecnicoDao)
        {
            _tecnicoDao = tecnicoDao;
            _tecnicoValidation = new TecnicoValidation();
        }

        public void Inserir(string nome, string especialidade)
        {
            var tecnico = new Models.Tecnico.Tecnico
            {
                Nome = nome,
                Especialidade = especialidade
            };
            _tecnicoValidation.Validar(tecnico);
            _tecnicoDao.Inserir(tecnico);
        }

        public List<Models.Tecnico.Tecnico> ListarTodos()
        {
            return _tecnicoDao.ListarTodos();
        }
    }
}
