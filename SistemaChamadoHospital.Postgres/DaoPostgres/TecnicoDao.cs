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
    public class TecnicoDao : ITecnicoDao
    {
        public void Inserir(Tecnico tecnico)
        {
            try
            {
                using (var conn = Conexao.ObterConexao())
                {
                    var cmd = new NpgsqlCommand("INSERT INTO tecnico (nome, email, senha) VALUES (@nome, @email, @senha)", conn);
                    cmd.Parameters.AddWithValue("nome", tecnico.Nome);
                    cmd.Parameters.AddWithValue("email", tecnico.Email);
                    cmd.Parameters.AddWithValue("senha", tecnico.Senha);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir técnico no banco de dados: " + ex.Message, ex);
            }
        }
        public Tecnico ObterPorId(int id)
        {
            Tecnico tecnico = null;
            try
            {
                using (var conn = Conexao.ObterConexao())
                {
                    var cmd = new NpgsqlCommand("SELECT id_tecnico, nome, email, senha FROM tecnico WHERE id_tecnico = @id", conn);
                    cmd.Parameters.AddWithValue("id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tecnico = new Tecnico
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                Email = reader.GetString(2),
                                Senha = reader.GetString(3)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter técnico por ID: " + ex.Message, ex);
            }
            return tecnico;
        }


        public void Atualizar(Tecnico tecnico)
        {
            try
            {
                using (var conn = Conexao.ObterConexao())
                {
                    var cmd = new NpgsqlCommand(
                        "UPDATE tecnico SET nome = @nome, email = @email WHERE id_tecnico = @id", conn);
                    cmd.Parameters.AddWithValue("id", tecnico.Id);
                    cmd.Parameters.AddWithValue("nome", tecnico.Nome);
                    cmd.Parameters.AddWithValue("email", tecnico.Email);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar técnico no banco de dados: " + ex.Message, ex);
            }
        }

        public void Deletar(int id)
        {
            try
            {
                using (var conn = Conexao.ObterConexao())
                {
                    var cmd = new NpgsqlCommand("DELETE FROM tecnico WHERE id_tecnico = @id", conn);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar técnico no banco de dados: " + ex.Message, ex);
            }
        }
        public List<Tecnico> ListarTodos()
        {
            List<Tecnico> tecnicos = new List<Tecnico>();
            try
            {
                using (var conn = Conexao.ObterConexao())
                {
                    var cmd = new NpgsqlCommand("SELECT id_tecnico, nome, email, senha FROM tecnico", conn); // senha incluída
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Tecnico tecnico = new Tecnico
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                Email = reader.GetString(2),
                                Senha = reader.GetString(3) // ← adicionado
                            };
                            tecnicos.Add(tecnico);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar técnicos: " + ex.Message, ex);
            }
            return tecnicos;
        }
        public Tecnico ObterPorEmailESenha(string email, string senhaHash)
        {
            Tecnico tecnico = null;
            try
            {
                using (var conn = Conexao.ObterConexao())
                {
                    var cmd = new NpgsqlCommand("SELECT id_tecnico, nome, email FROM tecnico WHERE email = @Email AND senha = @Senha", conn);
                    cmd.Parameters.AddWithValue("Email", email);
                    cmd.Parameters.AddWithValue("Senha", senhaHash);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tecnico = new Tecnico
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                Email = reader.GetString(2)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar técnico por email e senha: " + ex.Message, ex);
            }
            return tecnico;
        }


    }
}

