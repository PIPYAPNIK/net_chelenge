using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CrackThePassword
{
    class Program
    {
        private static SHA256Managed Sha256;

        static void Main(string[] args)
        {
            Sha256 = new SHA256Managed();

            string hash = "d887b8314484a54a1aafca4da2fa542ac3d8ff8cdf51625db97b15bd5c098cf0";

            for (int y = 1; y < 3000; y++)
            {
                for (int m = 1; m <= 12; m++)
                {
                    for (int d = 1; d <= 31; d++)
                    {
                        if (GetHash(d.ToString() + m.ToString() + y.ToString()) == hash)
                        {
                            Console.WriteLine(d.ToString() + m.ToString() + y.ToString());
                        }
                    }
                }
            }
            Console.ReadKey();
        }

        //Считает хэш любой строки
        public static string GetHash(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            byte[] hash = Sha256.ComputeHash(bytes);
            StringBuilder hashStringBuilder = new StringBuilder(64);

            foreach (byte x in hash)
            {
                hashStringBuilder.Append(string.Format("{0:x2}", x));
            }

            return hashStringBuilder.ToString();
        }
    }
}
