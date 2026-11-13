using System;
using System.Security.Cryptography;

namespace juarenact1
{
    internal class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            byte[] salt = new byte[16];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            using (var pbkdf2 = new Rfc2898DeriveBytes(
                password, salt, 600000, HashAlgorithmName.SHA256))
            {
                byte[] hash = pbkdf2.GetBytes(32);

                return Convert.ToBase64String(salt) + ":" +
                       Convert.ToBase64String(hash);
            }
        }

        public static bool VerifyPassword(
            string password, string storedHash)
        {
            try
            {
                string[] parts = storedHash.Split(':');

                if (parts.Length != 2)
                    return false;

                byte[] salt = Convert.FromBase64String(parts[0]);
                byte[] originalHash = Convert.FromBase64String(parts[1]);

                using (var pbkdf2 = new Rfc2898DeriveBytes(
                    password, salt, 600000, HashAlgorithmName.SHA256))
                {
                    byte[] newHash = pbkdf2.GetBytes(32);

                    if (originalHash.Length != newHash.Length)
                        return false;

                    int difference = 0;

                    for (int i = 0; i < originalHash.Length; i++)
                    {
                        difference |= originalHash[i] ^ newHash[i];
                    }

                    return difference == 0;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}