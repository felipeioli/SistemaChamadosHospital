using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Dao.TecnicoDao;
using SistemaChamadoHospital.Validation.TecnicoValidation;

namespace SistemaChamadoHospital.Service.TecnicoService
{
    public class TelefoneTecnicoService
    {
        private ITelefoneTecnicoDao _telefoneTecnicoDao;
        private TelefoneTecnicoValidation _telefoneTecnicoValidation;

        public TelefoneTecnicoService(ITelefoneTecnicoDao telefoneTecnicoDao)
        {
            _telefoneTecnicoDao = telefoneTecnicoDao;
            _telefoneTecnicoValidation = new TelefoneTecnicoValidation();
        }

        public void Inserir(int numero, string tipo, int idTecnico)
        {
            var telefoneTecnico = new Models.Tecnico.TelefoneTecnico
            {
                Id = numero,
                Tipo = tipo,
                IdTecnico = idTecnico
            };
            _telefoneTecnicoValidation.Validar(telefoneTecnico);
            _telefoneTecnicoDao.Inserir(telefoneTecnico);
        }
        public List<Models.Tecnico.TelefoneTecnico> ListarTodos()
        {
            return _telefoneTecnicoDao.ListarTodos();
        }
    }
}
