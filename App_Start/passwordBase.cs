using System.Security.Cryptography;
using System.Text;

namespace webs_banlaptop.App_Start
{
    public class passwordBase
    {
        public static string Hash(string text)
        {
            SHA1Managed sha1 = new SHA1Managed();
            byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("x3"));
            }
            return hashSb.ToString();
        }
    }
}