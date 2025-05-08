using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SistemaChamadoHospital.Dao;
using SistemaChamadoHospital.Models;

namespace SistemaChamadoHospitalPostgres.DaoPostgres
{

    public class UsuarioDao : IUsuarioDao
    {

        public void Inserir(Usuario u)
        {
            using (var conn = Conexao.ObterConexao())
            {
                var cmd = new NpgsqlCommand("INSERT INTO usuario (nome, email, area_trabalho) VALUES (@nome, @email, @area_trabalho)", conn);
                cmd.Parameters.AddWithValue("nome", u.Nome);
                cmd.Parameters.AddWithValue("email", u.Email);
                cmd.Parameters.AddWithValue("area_trabalho", u.AreaTrabalho);
            }
        }

        public List<Usuario> ListarTodos()
        {
            List<Usuario> usuario = new List<Usuario>();

            using (var conn = Conexao.ObterConexao())
            {
                var cmd = new NpgsqlCommand("SELECT id_usuario, nome, email, area_trabalho FROM usuario", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usuario.Add(new Usuario
                        {
                            Id = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            Email = reader.GetString(2),
                            AreaTrabalho = reader.GetString(3)
                        });
                    }
                }
                return usuario;
            }
        }
    }
}

