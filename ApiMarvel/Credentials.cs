using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Security.Cryptography;

namespace ApiMarvel
{
    internal class Credentials
    {
        public string public_key = "a02e3347e7c15763bd96af1f46e1adee";

        private string private_key = "48c474302a5572e72e9c860e171f5e460b9274db";

        private long now;

        public string Hash()
        {
            long now = DateTimeOffset.Now.ToUnixTimeSeconds();
            SetTimestamp(now);

            string hash = MD5Hash(now + private_key + public_key);

            return hash;
        }

        public long GetTimestamp()
        {
            return now;
        }

        private void SetTimestamp(long time)
        {
            now = time;
        }

        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

    }
}
