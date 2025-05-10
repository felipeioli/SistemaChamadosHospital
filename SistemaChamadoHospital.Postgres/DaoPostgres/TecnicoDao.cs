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
    public class TecnicoDao : ITecnicoDao
    {
        public void Inserir(Tecnico tecnico)
        {
            try
            {
                using (var conn = Conexao.ObterConexao())
                {
                    var cmd = new NpgsqlCommand(
                        "INSERT INTO tecnico (nome, email) VALUES (@nome, @email)", conn);

                    cmd.Parameters.AddWithValue("nome", tecnico.Nome);
                    cmd.Parameters.AddWithValue("email", tecnico.Email);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir técnico no banco de dados: " + ex.Message, ex);
            }
        }

        public List<Tecnico> ListarTodos()
        {
            var tecnicos = new List<Tecnico>();

            try
            {
                using (var conn = Conexao.ObterConexao())
                {
                    var cmd = new NpgsqlCommand("SELECT id_tecnico, nome, email FROM tecnico", conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tecnicos.Add(new Tecnico
                            {
                                Id = reader.GetInt32(0),
                                Nome = reader.GetString(1),
                                Email = reader.GetString(2)
                            });
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
    }
 }

