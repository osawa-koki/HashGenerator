using System.Security.Cryptography;
using System.Text;

const string target_word = "ABC";

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("");
Console.WriteLine("===== Hashing Target \"{0}\" =====", target_word);
Console.WriteLine("");
Console.ResetColor();

using (var hasher = MD5.Create())
{
  var hashed = hasher.ComputeHash(Encoding.UTF8.GetBytes(target_word));
  Console.WriteLine($"   MD5 -> {BitConverter.ToString(hashed).Replace("-", "")}");
}

using (var hasher = SHA1.Create())
{
  var hashed = hasher.ComputeHash(Encoding.UTF8.GetBytes(target_word));
  Console.WriteLine($"  SHA1 -> {BitConverter.ToString(hashed).Replace("-", "")}");
}

using (var hasher = SHA256.Create())
{
  var hashed = hasher.ComputeHash(Encoding.UTF8.GetBytes(target_word));
  Console.WriteLine($"SHA254 -> {BitConverter.ToString(hashed).Replace("-", "")}");
}

using (var hasher = SHA384.Create())
{
  var hashed = hasher.ComputeHash(Encoding.UTF8.GetBytes(target_word));
  Console.WriteLine($"SHA384 -> {BitConverter.ToString(hashed).Replace("-", "")}");
}

using (var hasher = SHA512.Create())
{
  var hashed = hasher.ComputeHash(Encoding.UTF8.GetBytes(target_word));
  Console.WriteLine($"SHA512 -> {BitConverter.ToString(hashed).Replace("-", "")}");
}
