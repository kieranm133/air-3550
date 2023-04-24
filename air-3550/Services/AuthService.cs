using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace air_3550.Services
{
    public class AuthService
    {
        public static string HashPassword(string password)
        {
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] bytePass = Encoding.UTF8.GetBytes(password);
                byte[] byteHash = sha512.ComputeHash(bytePass);
                return Encoding.UTF8.GetString(byteHash);
            }
        }
    }
}
