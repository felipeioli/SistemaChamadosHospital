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
            using (var conn = Conexao.ObterConexao())
            {
                var cmd = new NpgsqlCommand("INSERT INTO tecnico (nome, email) VALUES (@nome, @email)", conn);
                cmd.Parameters.AddWithValue("nome", tecnico.Nome);
                cmd.Parameters.AddWithValue("especialidade", tecnico.Email);

            }
        }

        public List<Tecnico> ListarTodos()
        {
            List<Tecnico> tecnico = new List<Tecnico>();

            using (var conn = Conexao.ObterConexao())
            {
                var cmd = new NpgsqlCommand("SELECT id_tecnico, nome, email FROM tecnico", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tecnico.Add(new Tecnico
                        {
                            Id = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            Email = reader.GetString(2)
                        });
                    }
                }
                return tecnico;
            }
        }
    }
 }

