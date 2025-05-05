using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Dao;
using SistemaChamadoHospital.Dao.UsuarioDao;
using SistemaChamadoHospital.Models.Usuario;
using SistemaChamadoHospital.Validation;
using SistemaChamadoHospital.Validation.UsuarioValidation;

namespace SistemaChamadoHospital.Service.UsuarioService1
{
    public class UsuarioService
    {
        private IUsuarioDao _usuarioDao;
        private UsuarioValidation _usuarioValidation;

        public UsuarioService(IUsuarioDao usuarioDao)
        {
            _usuarioDao = usuarioDao;
            _usuarioValidation = new UsuarioValidation();
        }
        public void Inserir(string nome, string email, string areaTrabalho)
        {
            var usuario = new Usuario
            {
                Nome = nome,
                Email = email,
                AreaTrabalho = areaTrabalho

            };
            _usuarioValidation.Validar(usuario);
            _usuarioDao.Inserir(usuario);
        }
        
        public List<Usuario> ListarTodos()
        {
            return _usuarioDao.ListarTodos();
        }
    }
}