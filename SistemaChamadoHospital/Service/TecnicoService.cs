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

        public Tecnico ObterPorId(int id)
        {
            return _tecnicoDao.ObterPorId(id);
        }

        public void Atualizar(Tecnico t)
        {
            _tecnicoValidation.Validar(t);
            _tecnicoDao.Atualizar(t);
        }

        public void Deletar(int id)
        {
            _tecnicoDao.Deletar(id);
        }

        public List<Tecnico> ListarTodos()
        {
            return _tecnicoDao.ListarTodos();
        }

        public Tecnico ObterPorEmailESenha(string email, string senhaHash)
        {
            return _tecnicoDao.ObterPorEmailESenha(email, senhaHash);
        }

    }
}
