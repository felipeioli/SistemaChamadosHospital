using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Dao;
using SistemaChamadoHospital.Models;
using SistemaChamadoHospital.Validation;

namespace SistemaChamadoHospital.Service
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

        public void Inserir(string nome, string email)
        {
            var tecnico = new Tecnico
            {
                Nome = nome,
                Email = email
            };
            _tecnicoValidation.Validar(tecnico);
            _tecnicoDao.Inserir(tecnico);
        }

        public List<Tecnico> ListarTodos()
        {
            return _tecnicoDao.ListarTodos();
        }
    }
}
