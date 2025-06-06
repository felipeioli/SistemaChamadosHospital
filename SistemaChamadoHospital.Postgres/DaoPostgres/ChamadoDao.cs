﻿using System;
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
                var cmd = new NpgsqlCommand("INSERT INTO chamado (status, prioridade, descricao, data_abertura, fk_usuario_id_usuario) VALUES (@status, @prioridade, @descricao, @data_abertura, @usuario)", conn);
                cmd.Parameters.AddWithValue("status", chamado.Status);
                cmd.Parameters.AddWithValue("prioridade", chamado.Prioridade);
                cmd.Parameters.AddWithValue("descricao", chamado.Descricao);
                cmd.Parameters.AddWithValue("data_abertura", chamado.DataAbertura);
                cmd.Parameters.AddWithValue("usuario", chamado.IdUsuario);

                cmd.ExecuteNonQuery();
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
                            DataFechamento = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5),
                            IdUsuario = reader.GetInt32(6),
                            IdSolucao = reader.IsDBNull(7) ? null : reader.GetInt32(7)
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
                cmd.ExecuteNonQuery();
            }
        }

        public List<Chamado> ListarPorUsuario(int idUsuario)
        {
            var chamados = new List<Chamado>();
            using (var conn = Conexao.ObterConexao())
            {
                var cmd = new NpgsqlCommand("SELECT * FROM chamado WHERE fk_usuario_id_usuario = @idUsuario", conn);
                cmd.Parameters.AddWithValue("idUsuario", idUsuario);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        chamados.Add(new Chamado
                        {
                            Id = reader.GetInt32(0),
                            Status = reader.GetString(1),
                            Prioridade = reader.GetString(2),
                            Descricao = reader.GetString(3),
                            DataAbertura = reader.GetDateTime(4),
                            DataFechamento = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5),
                            IdUsuario = reader.GetInt32(6),
                            IdSolucao = reader.IsDBNull(7) ? null : reader.GetInt32(7)
                        });
                    }
                }
            }
            return chamados;
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
