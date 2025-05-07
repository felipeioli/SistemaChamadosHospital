using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SistemaChamadoHospital.Dao;
using SistemaChamadoHospital.Models;

namespace SistemaChamadoHospitalPostgres.DaoPostgres
{
    internal class SolucaoDao : ISolucaoDao
    {
        public void Inserir(Solucao solucao)
        {
            using (var conn = Conexao.ObterConexao())
            {
                var cmd = new NpgsqlCommand("INSERT INTO solucao (descricao) VALUES (@descricao)", conn);
                cmd.Parameters.AddWithValue("descricao", solucao.Descricao);
            }
        }

        public List<Solucao> ListarTodos()
        {
            List<Solucao> solucao = new List<Solucao>();

            using (var conn = Conexao.ObterConexao())
            {
                var cmd = new NpgsqlCommand("SELECT * FROM solucao", conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    solucao.Add(new Solucao
                    {
                        Id = reader.GetInt32(0),
                        Descricao = reader.GetString(1),
                        IdTecnico = reader.GetInt32(2)
                    });
                }
            }
            return solucao;
        }
    }
}
