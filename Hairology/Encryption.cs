using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hairology
{
    public class Encryption
    {
        private string _hashedPassword = default!;
        private StringBuilder _strBuilder = new StringBuilder();
        /// <summary>
        /// generates an MD5 hash of a given string parameter
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string CreateMD5Hash(string input)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            // compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(input));
            //get hash result after compute it  
            byte[] result = md5.Hash;
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                _strBuilder.Append(result[i].ToString("x2"));
                input = "";
            }
            _hashedPassword = _strBuilder.ToString();
            return _hashedPassword;
        }
    }
}
