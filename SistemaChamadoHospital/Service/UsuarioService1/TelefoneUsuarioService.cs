using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Dao.UsuarioDao;
using SistemaChamadoHospital.Validation.UsuarioValidation;


namespace SistemaChamadoHospital.Service.UsuarioService1
{
    public class TelefoneUsuarioService
    {
        private ITelefoneUsuarioDao _telefoneUsuarioDao;
        private TelefoneUsuarioValidation _telefoneUsuarioValidation;

        public TelefoneUsuarioService(ITelefoneUsuarioDao telefoneUsuarioDao)
        {
            _telefoneUsuarioDao = telefoneUsuarioDao;
            _telefoneUsuarioValidation = new TelefoneUsuarioValidation();
        }
        public void Inserir(int numero, string tipo, int idUsuario)
        {
            var telefoneUsuario = new Models.Usuario.TelefoneUsuario
            {
                Id = numero,
                Tipo = tipo,
                IdUsuario = idUsuario
            };
            _telefoneUsuarioValidation.Validar(telefoneUsuario);
            _telefoneUsuarioDao.Inserir(telefoneUsuario);
        }
        public List<Models.Usuario.TelefoneUsuario> ListarTodos()
        {
            return _telefoneUsuarioDao.ListarTodos();
        }
    }
}
