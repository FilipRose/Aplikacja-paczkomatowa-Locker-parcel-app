using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Ostatecznietotenforms
{
   public  class HashCode
    {
      public static string HashData( string Haslo)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] HasloByte = Encoding.ASCII.GetBytes(Haslo);
            byte[] encryptedByte = sha1.ComputeHash(HasloByte);

            return Convert.ToBase64String(encryptedByte);

        }
    }

    
}
