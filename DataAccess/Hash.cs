﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace DataAccess
{
    public static class Hash
    {
        public static string GetHash(string passwordString, string saltString)
        {
            HashAlgorithm algorithm = new SHA256Managed();

            var passwordByte = Encoding.UTF8.GetBytes(passwordString);
            var saltByte = Encoding.UTF8.GetBytes(saltString);

            byte[] plainTextWithSaltBytes = new byte[passwordByte.Length + saltByte.Length];

            for (int i = 0; i < passwordByte.Length; i++)
            {
                plainTextWithSaltBytes[i] = passwordByte[i];
            }
            for (int i = 0; i < saltByte.Length; i++)
            {
                plainTextWithSaltBytes[passwordByte.Length + i] = saltByte[i];
            }

            var hash = algorithm.ComputeHash(plainTextWithSaltBytes);
            return Convert.ToBase64String(hash);
        }
    }
}
