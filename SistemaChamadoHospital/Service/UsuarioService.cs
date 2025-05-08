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