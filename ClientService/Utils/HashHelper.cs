using System.Text;
using System.Security.Cryptography;

namespace BeSafe.Utils
{
    public static class HashHelper
    {
        public static string GetSHA256(byte[] buffer)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(buffer);
                return ByteArrayToString(hashBytes);
            }
        }

        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);

            return hex.ToString();
        }
    }
}