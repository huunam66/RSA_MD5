using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuNam_2001207307_Lab2_1_RSA_MD5
{
    class MD5site
    {
        public static String Encrypt(String txt)
        {
            byte[] Source = new UnicodeEncoding().GetBytes(txt);
            byte[] Hash = new MD5CryptoServiceProvider().ComputeHash(Source);
            return BitConverter.ToString(Hash).Replace("-", "").ToLower();
        }
    }
}
