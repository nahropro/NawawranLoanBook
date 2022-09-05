using NLB.Server.Core;
using System.Security.Cryptography;
using System.Text;

namespace NLB.Server.Services;

public class HashService : IHashService
{
    private readonly HashAlgorithm hashAlgorithm;

    public HashService(HashAlgorithm hashAlgorithm)
    {
        this.hashAlgorithm = hashAlgorithm;
    }

    public HashModel GenerateHash(string password)
    {
        HashModel result = new HashModel();

        result.Salt = Guid.NewGuid().ToString();
        string passwordWithSalt = password + result.Salt;
        result.PasswordHash = Encoding.UTF8.GetString(hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordWithSalt)));

        return result;
    }

    public bool CheckPassword(string password, string salt, string passwordHash)
    {
        string passwordWithSalt = password + salt;
        string generatedPassowrdHash = Encoding.UTF8.GetString(hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordWithSalt)));

        return generatedPassowrdHash.Equals(passwordHash);
    }
}
