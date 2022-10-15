using System;
using System.Security.Cryptography;
using System.Text;

const string target_word = "ABC";

using (var hasher = MD5.Create())
{
    var hashed = hasher.ComputeHash(Encoding.UTF8.GetBytes(target_word));
    Console.WriteLine($"MD5 -> {BitConverter.ToString(hashed).Replace("-", "")}");
}

using (var hasher = SHA256.Create())
{
    var hashed = hasher.ComputeHash(Encoding.UTF8.GetBytes(target_word));
    Console.WriteLine($"SHA254 -> {BitConverter.ToString(hashed).Replace("-", "")}");
}
