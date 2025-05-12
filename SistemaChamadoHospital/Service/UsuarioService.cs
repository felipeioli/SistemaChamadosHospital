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

        public void Inserir(Usuario u)
        {
            _usuarioDao.Inserir(u);
        }

        public Usuario ObterPorId(int id)
        {
            return _usuarioDao.ObterPorId(id);
        }

        public void Atualizar(Usuario u)
        {
            _usuarioValidation.Validar(u);
            _usuarioDao.Atualizar(u);
        }

        public void Deletar(int id)
        {
            _usuarioDao.Deletar(id);
        }

        public List<Usuario> ListarTodos()
        {
            return _usuarioDao.ListarTodos();
        }

    }
}