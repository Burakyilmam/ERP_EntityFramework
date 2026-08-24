using System;
using System.Security.Cryptography;

namespace ERP_EntityFramework.Core.Helpers
{
    public static class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            byte[] salt = new byte[16];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000))
            {
                byte[] hash = pbkdf2.GetBytes(32);

                return Convert.ToBase64String(salt) + "." + Convert.ToBase64String(hash);
            }
        }

        public static bool VerifyPassword(string password, string storedHash)
        {
            if (string.IsNullOrWhiteSpace(storedHash)) return false;

            string[] parts = storedHash.Split('.');

            if (parts.Length != 2) return false;

            byte[] salt = Convert.FromBase64String(parts[0]);
            byte[] expectedHash = Convert.FromBase64String(parts[1]);

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000))
            {
                byte[] actualHash = pbkdf2.GetBytes(32);

                if (actualHash.Length != expectedHash.Length) return false;

                int result = 0;

                for (int i = 0; i < actualHash.Length; i++)
                {
                    result |= actualHash[i] ^ expectedHash[i];
                }

                return result == 0;
            }
        }
    }
}