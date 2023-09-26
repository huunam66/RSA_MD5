using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHuuNam_2001207307_Lab2_1_RSA_MD5
{
    class RSAsite
    {
        private RSACryptoServiceProvider rsa;
        private RSAParameters private_key;
        private RSAParameters public_key;
        private String MD5_code;
        private byte[] Source;
        private byte[] Result;

        public RSAsite(RSAParameters pr, RSAParameters pb)
        {
            this.rsa = new RSACryptoServiceProvider();
            this.rsa.KeySize = 2048;
            this.private_key = pr;
            this.public_key = pb;
            Source = new byte[2048];
            Result = new byte[2048];
        }

        public String Encrypt(String txt)
        {
            try
            {
                this.rsa.ImportParameters(this.public_key);
                Source = Encoding.Unicode.GetBytes(txt);
                Result = this.rsa.Encrypt(Source, false);
                String Result_String = Convert.ToBase64String(Result);
                this.MD5_code = MD5site.Encrypt(Result_String);
                return Result_String;
            }
            catch (Exception e) { return null; }
        }

        public String Decrypt(String txt)
        {
            try
            {
                this.rsa.ImportParameters(this.private_key);
                Source = Convert.FromBase64String(txt);
                Result = this.rsa.Decrypt(Source, false);
                return Encoding.Unicode.GetString(Result);
            }
            catch (Exception e) { return null; }
        }

        public RSAParameters getPublic_key()
        {
            return this.public_key;
        }

        public String getMD5_code()
        {
            return this.MD5_code;
        }
    }
}
