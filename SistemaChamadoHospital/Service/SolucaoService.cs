using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Dao;
using SistemaChamadoHospital.Validation;

namespace SistemaChamadoHospital.Service
{
    public class SolucaoService
    {
        private ISolucaoDao _solucaoDao;
        private SolucaoValidation _solucaoValidation;
        public SolucaoService(ISolucaoDao solucaoDao)
        {
            _solucaoDao = solucaoDao;
            _solucaoValidation = new SolucaoValidation();
        }
        public void Inserir(string descricao, DateTime dataSolucao, int idTecnico)
        {
            var solucao = new Models.Solucao
            {
                Descricao = descricao,
                DataSolucao = dataSolucao,
                IdTecnico = idTecnico
            };
            _solucaoValidation.Validar(solucao);
            _solucaoDao.Inserir(solucao);
        }
        public List<Models.Solucao> ListarTodos()
        {
            return _solucaoDao.ListarTodos();
        }
    }
}
