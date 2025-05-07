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
    public class SetorDao : ISetorDao
    {
        public void Inserir(Setor setor)
        {
            using (var conn = Conexao.ObterConexao())
            {
                var cmd = new NpgsqlCommand("INSERT INTO setor (nome, local) VALUES (@nome, @local)", conn);
                cmd.Parameters.AddWithValue("nome", setor.Nome);
                cmd.Parameters.AddWithValue("local", setor.Local);
            }
        }

        public List<Setor> ListarTodos()
        {
            List<Setor> setor = new List<Setor>();

            using (var conn = Conexao.ObterConexao())
            {
                var cmd = new NpgsqlCommand("SELECT * FROM setor", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        setor.Add(new Setor
                        { 
                            Id = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            Local = reader.GetString(2)
                        });
                    }
                }
            }
            return setor;
        }
    }
}
