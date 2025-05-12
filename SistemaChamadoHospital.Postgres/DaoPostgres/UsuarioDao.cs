using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SistemaChamadoHospital.Dao;
using SistemaChamadoHospital.Models;
using SistemaChamadoHospital.Utils;

namespace SistemaChamadoHospitalPostgres.DaoPostgres
{

    public class UsuarioDao : IUsuarioDao
    {

        public void Inserir(Usuario u)
        {
            try
            {
                using (var conn = Conexao.ObterConexao())
                {
                    var cmd = new NpgsqlCommand("INSERT INTO usuario (nome, email, area_trabalho, senha) VALUES (@nome, @email, @area, @senha)", conn);
                    cmd.Parameters.AddWithValue("nome", u.Nome);
                    cmd.Parameters.AddWithValue("email", u.Email);
                    cmd.Parameters.AddWithValue("area", u.AreaTrabalho);
                    cmd.Parameters.AddWithValue("senha", u.Senha);
                    cmd.ExecuteNonQuery();
                }
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir usuário no banco de dados: " + ex.Message, ex);
            }

        }

        public Usuario ObterPorId(int id)
        {
            Usuario usuario = null;
            try
            {
                using (var conn = Conexao.ObterConexao())
                {
                    var cmd = new NpgsqlCommand("SELECT id_usuario, nome, email, area_trabalho FROM usuario WHERE id_usuario = @id", conn);
                    cmd.Parameters.AddWithValue("id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                Email = reader.GetString(2),
                                AreaTrabalho = reader.GetString(3)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar usuário: " + ex.Message, ex);
            }
            return usuario;
        }

        public void Atualizar(Usuario u)
        {
            try
            {
                using (var conn = Conexao.ObterConexao())
                {
                    var cmd = new NpgsqlCommand("UPDATE usuario SET nome = @nome, email = @email, area_trabalho = @area_trabalho WHERE id_usuario = @id", conn);
                    cmd.Parameters.AddWithValue("nome", u.Nome);
                    cmd.Parameters.AddWithValue("email", u.Email);
                    cmd.Parameters.AddWithValue("area_trabalho", u.AreaTrabalho);
                    cmd.Parameters.AddWithValue("id", u.Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar usuário: " + ex.Message, ex);
            }
        }

        public void Deletar(int id)
        {
            try
            {
                using (var conn = Conexao.ObterConexao())
                {
                    var cmdDeleteChamados = new NpgsqlCommand("DELETE FROM chamado WHERE fk_usuario_id_usuario = @id", conn);
                    cmdDeleteChamados.Parameters.AddWithValue("id", id);
                    cmdDeleteChamados.ExecuteNonQuery();

                    var cmd = new NpgsqlCommand("DELETE FROM usuario WHERE id_usuario = @id", conn);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery(); 
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar usuário: " + ex.Message, ex);
            }
        }

        public List<Usuario> ListarTodos()
        {
            var usuarios = new List<Usuario>();

            try
            {
                using (var conn = Conexao.ObterConexao())
                {
                    var cmd = new NpgsqlCommand("SELECT id_usuario, nome, email, area_trabalho, senha FROM usuario", conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuarios.Add(new Usuario
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                Email = reader.GetString(2),
                                AreaTrabalho = reader.GetString(3),
                                Senha = reader.GetString(4)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar usuários: " + ex.Message, ex);
            }

            return usuarios;
        }
        public Usuario ObterPorEmailESenha(string email, string senhaHash)
        {
            Usuario usuario = null;
            try
            {
                using (var conn = Conexao.ObterConexao())
                {
                    var cmd = new NpgsqlCommand("SELECT id_usuario, nome, email, area_trabalho, senha FROM usuario WHERE email = @email AND senha = @senha", conn);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("senha", senhaHash);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                Email = reader.GetString(2),
                                AreaTrabalho = reader.GetString(3),
                                Senha = reader.GetString(4)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar usuário por email e senha: " + ex.Message, ex);
            }
            return usuario;
        }

    }
}

