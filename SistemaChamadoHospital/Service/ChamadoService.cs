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

        public void Inserir(string status, string prioridade, string descricao, DateTime dataAbertura, int idEquipamento, int idSolucao, int idUsuario)
        {
            var chamado = new Chamado
            {
                Status = status,
                Prioridade = prioridade,
                Descricao = descricao,
                DataAbertura = dataAbertura,
                IdEquipamento = idEquipamento,
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

        public void AbrirChamado(Chamado chamado)
        {
            chamado.DataAbertura = DateTime.Now;
            chamado.Status = "Aberto";
            _chamadoValidation.Validar(chamado);
            _chamadoDao.Inserir(chamado);
        }

        public void AtualizarChamado(Chamado chamado)
        {
            _chamadoValidation.Validar(chamado);
            _chamadoDao.Atualizar(chamado);
        }

        public void DeletarChamado(int id)
        {
            _chamadoDao.Deletar(id);
        }


        public void AtualizarStatusFechamento(int idChamado, DateTime dataFechamento)
        {
            _chamadoDao.AtualizarStatusFechamento(idChamado, dataFechamento);

        }
    }
}

