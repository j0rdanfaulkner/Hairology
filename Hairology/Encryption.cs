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
        private string _input = default!;
        private StringBuilder _strBuilder = new StringBuilder();
        /// <summary>
        /// constructor that sets input string parameter to the private input string variable of the class
        /// </summary>
        /// <param name="input"></param>
        public Encryption (string input)
        {
            _input = input;
            _hashedPassword = "";
        }
        /// <summary>
        /// generates an MD5 hash of a given string parameter
        /// </summary>
        /// <returns name="_hashedPassword"></returns>
        public string CreateMD5Hash()
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            // compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(_input));
            // get hash result after compute it  
            byte[] result = md5.Hash;
            for (int i = 0; i < result.Length; i++)
            {
                // change it into 2 hexadecimal digits for each byte  
                _strBuilder.Append(result[i].ToString("x2"));
                _input = "";
            }
            _hashedPassword = _strBuilder.ToString();
            return _hashedPassword;
        }
        /// <summary>
        /// clears input string and hashed password when object is no longer needed for added security
        /// </summary>
        ~Encryption()
        {
            _input = null!;
            _hashedPassword = null!;
        }
    }
}
