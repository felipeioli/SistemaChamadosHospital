using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamadoHospital.Models;
using Npgsql;
using SistemaChamadoHospital.Models.Usuario;
using SistemaChamadoHospitalPostgres.DaoPostgres;
using SistemaChamadoHospital.Dao.UsuarioDao;

namespace SistemaChamadoHospitalPostgres.DaoPostgres
{

    public class TelefoneUsuarioDao : ITelefoneUsuarioDao
    {
        public void Inserir(TelefoneUsuario telefoneUsuario)
        {
            using var conn = Conexao.ObterConexao();
            var cmd = new NpgsqlCommand("INSERT INTO telefone_usuario (telefone_usuario, tipo_telefone) VALUES (@telefone_usuario, @tipo_telefone)", conn);
            cmd.Parameters.AddWithValue("telefone_usuario", telefoneUsuario.Id);
            cmd.Parameters.AddWithValue("tipo_telefone", telefoneUsuario.Tipo);
            cmd.ExecuteNonQuery();
        }

        public List<TelefoneUsuario> ListarTodos()
        {
            var lista = new List<TelefoneUsuario>();
            using var conn = Conexao.ObterConexao();
            var cmd = new NpgsqlCommand("SELECT * FROM telefone_usuario", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                lista.Add(new TelefoneUsuario
                {
                    Id = reader.GetInt32(0),
                    Tipo = reader.GetString(1),
                    IdUsuario = reader.GetInt32(2)
                });
            }
            return lista;
        }
    }
}

