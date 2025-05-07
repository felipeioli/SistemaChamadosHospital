using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SistemaChamadoHospital.Dao.TecnicoDao;
using SistemaChamadoHospital.Models.Tecnico;

namespace SistemaChamadoHospitalPostgres.DaoPostgres.TecnicoDaoPostgres
{
    public class TelefoneTecnicoDao : ITelefoneTecnicoDao
    {
        public void Inserir(TelefoneTecnico telefoneTecnico)
        {
            using (var conn = Conexao.ObterConexao())
            {
                var cmd = new NpgsqlCommand("INSERT INTO telefone_tecnico (telefone_tecnico, tipo_telefone) VALUES (@telefone_tecnico, @tipo_telefone)", conn);
                cmd.Parameters.AddWithValue("telefone_tecnico", telefoneTecnico.IdTecnico);
                cmd.Parameters.AddWithValue("tipo_telefone", telefoneTecnico.Tipo);

            }
        }

        public List<TelefoneTecnico> ListarTodos()
        {
            List<TelefoneTecnico> telefonetecnico = new List<TelefoneTecnico>();

            using (var conn = Conexao.ObterConexao())
            {
                var cmd = new NpgsqlCommand("SELECT * FROM telefone_tecnico", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        telefonetecnico.Add(new TelefoneTecnico
                        {
                            Id = reader.GetInt32(0),
                            Tipo = reader.GetString(1),
                            IdTecnico = reader.GetInt32(2)
                        });
                    }
                }
                return telefonetecnico;
            }
        }
    }
}
