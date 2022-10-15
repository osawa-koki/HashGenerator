using System;
using System.Security.Cryptography;
using System.Text;


using (var hasher = MD5.Create())
{
    var md5_hashed = hasher.ComputeHash(Encoding.UTF8.GetBytes("ABC"));
    Console.WriteLine($"MD5 -> {BitConverter.ToString(md5_hashed).Replace("-", "")}");
}


