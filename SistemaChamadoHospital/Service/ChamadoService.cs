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
    public class ChamadoService
    {
        private IChamadoDao _chamadoDao;
        private ChamadoValidation _chamadoValidation;

        public ChamadoService(IChamadoDao chamadoDao)
        {
            _chamadoDao = chamadoDao;
            _chamadoValidation = new ChamadoValidation();
        }

        public void Inserir(string status, string prioridade,string descricao, DateTime dataAbertura, int idEquipamento, int idSetor,int idSolucao,int idUsuario)
        {
            var chamado = new Chamado
            {
                Status = status,
                Prioridade = prioridade,
                Descricao = descricao,
                DataAbertura = dataAbertura,
                IdEquipamento = idEquipamento,
                IdSetor = idSetor,
                IdSolucao = idSolucao,
                IdUsuario = idUsuario
            };
            _chamadoValidation.Validar(chamado);
            _chamadoDao.Inserir(chamado);
        }

        public List<Chamado> ListarTodos()
        {
            return _chamadoDao.ListarTodos();
        }
    }
}
