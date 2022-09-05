using NLB.Server.Core;

namespace NLB.Server.Services
{
    public interface IHashService
    {
        bool CheckPassword(string password, string salt, string passwordHash);
        HashModel GenerateHash(string password);
    }
}