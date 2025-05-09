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
    public class EquipamentoDao : IEquipamentoDao
    {
        public void Inserir(Equipamento equipamento)
        {
            using (var conn = Conexao.ObterConexao())
            {
                var cmd = new NpgsqlCommand("INSERT INTO usuario (nome, modelo) VALUES (@nome, @modelo)", conn);
                cmd.Parameters.AddWithValue("nome", equipamento.Nome);
                cmd.Parameters.AddWithValue("modelo", equipamento.Modelo);

            }
        }

        public List<Equipamento> ListarTodos()
        {
            List<Equipamento> equipamento = new List<Equipamento>();

            using (var conn = Conexao.ObterConexao())
            {
                var cmd = new NpgsqlCommand("SELECT id_equipamento, nome, modelo FROM equipamento", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        equipamento.Add(new Equipamento
                        {
                            Id = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            Modelo = reader.GetString(2)
                        });
                    }
                }
            }
            return equipamento;
        }
    }
}
