using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SistemaChamadoHospitalPostgres.DaoPostgres
{
    public class Conexao
    {
        private static string connString = "Host=localhost;Username=postgres;Password=dbadmin;Database=pim";

        public static NpgsqlConnection ObterConexao()
        {
            var conexao = new NpgsqlConnection(connString);
            conexao.Open();
            return conexao;
        }
    }
}