using System;
using System.Security.Cryptography;
using System.Text;


using (var hasher = MD5.Create())
{
    var hashed = hasher.ComputeHash(Encoding.UTF8.GetBytes("ABC"));
    Console.WriteLine($"MD5 -> {BitConverter.ToString(hashed).Replace("-", "")}");
}

using (var hasher = SHA256.Create())
{
    var hashed = hasher.ComputeHash(Encoding.UTF8.GetBytes("ABC"));
    Console.WriteLine($"MD5 -> {BitConverter.ToString(hashed).Replace("-", "")}");
}
