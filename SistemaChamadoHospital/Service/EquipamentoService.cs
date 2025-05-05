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
    public class EquipamentoService
    {
        private IEquipamentoDao _equipamentoDao;
        private EquipamentoValidation _equipamentoValidation;

        public EquipamentoService(IEquipamentoDao equipamentoDao)
        {
            _equipamentoDao = equipamentoDao;
            _equipamentoValidation = new EquipamentoValidation();
        }

        public void Inserir(string nome, string modelo)
        {
            var equipamento = new Equipamento
            {
                Nome = nome,
                Modelo = modelo
            };
            _equipamentoValidation.Validar(equipamento); 
            _equipamentoDao.Inserir(equipamento);
        }

        public List<Equipamento> ListarTodos()
        {
            return _equipamentoDao.ListarTodos();
        }
    }
}
