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

        public void Inserir(Tecnico t)
        {
            _tecnicoDao.Inserir(t);
        }

        public List<Tecnico> ListarTodos()
        {
            return _tecnicoDao.ListarTodos();
        }
    }
}
