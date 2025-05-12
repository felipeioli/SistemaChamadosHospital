using System.Security.Cryptography;
using System.Text;

namespace SistemaChamadoHospital.Utils
{
    public static class SenhaUtil
    {
        public static string GerarHash(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(senha);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
