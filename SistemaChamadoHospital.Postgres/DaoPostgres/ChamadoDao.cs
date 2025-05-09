using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SistemaChamadoHospital.Dao;
using SistemaChamadoHospital.Models;

namespace SistemaChamadoHospitalPostgres.DaoPostgres
{
    public class ChamadoDao : IChamadoDao
    {
        public void Inserir(Chamado chamado)
        {
            using (var conn = Conexao.ObterConexao())
            {
                var cmd = new NpgsqlCommand("INSERT INTO chamado (status, prioridade, descricao) VALUES (@status, @prioridade, @descricao)", conn);
                cmd.Parameters.AddWithValue("status", chamado.Status);
                cmd.Parameters.AddWithValue("prioridade", chamado.Prioridade);
                cmd.Parameters.AddWithValue("descricao", chamado.Descricao);
            }
        }

        public List<Chamado> ListarTodos()
        {
            var chamado = new List<Chamado>();
            using (var conn = Conexao.ObterConexao())
            {
                var cmd = new NpgsqlCommand("SELECT * FROM chamado", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        chamado.Add(new Chamado
                        {
                            Id = reader.GetInt32(0),
                            Status = reader.GetString(1),
                            Prioridade = reader.GetString(2),
                            Descricao = reader.GetString(3),
                            DataAbertura = reader.GetDateTime(4),
                            DataFechamento = reader.GetDateTime(5),
                            IdUsuario = reader.GetInt32(6),
                            IdEquipamento = reader.GetInt32(7),
                            IdSolucao = reader.GetInt32(8)
                        });
                    }
                }
            }
            return chamado;
        }

        public void Atualizar(Chamado chamado)
        {
            using (var conn = Conexao.ObterConexao())
            {
                var cmd = new NpgsqlCommand("UPDATE chamado SET status = @status, prioridade = @prioridade, descricao = @descricao WHERE id_chamado = @id", conn);
                cmd.Parameters.AddWithValue("status", chamado.Status);
                cmd.Parameters.AddWithValue("prioridade", chamado.Prioridade);
                cmd.Parameters.AddWithValue("descricao", chamado.Descricao);
                cmd.Parameters.AddWithValue("id", chamado.Id);
            }
        }

        public void Deletar(int id)
        {
            using (var conn = Conexao.ObterConexao())
            {
                var cmd = new NpgsqlCommand("DELETE FROM chamado WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
            }
        }


        public void AtualizarStatusFechamento(int idChamado, DateTime dataFechamento)
        {
            using var conn = Conexao.ObterConexao();
            var query = "UPDATE chamado SET status = @status, data_fechamento = @fechamento WHERE id_chamado = @id";
            using var cmd = new NpgsqlCommand(query, conn);

            cmd.Parameters.AddWithValue("status", "Fechado");
            cmd.Parameters.AddWithValue("fechamento", dataFechamento);
            cmd.Parameters.AddWithValue("id", idChamado);

            cmd.ExecuteNonQuery();
        }

    }
}
