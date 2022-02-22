using GrainRestaurants.Core.Util;
using System;

namespace GrainRestaurants.Application.Util
{
    public class Cryptography : ICryptography
    {
        public bool Compare(string password, string hash) => BCrypt.Net.BCrypt.Verify(password, hash);

        public string GenerareToken() => Guid.NewGuid().ToString();

        public string Hash(string password) => BCrypt.Net.BCrypt.HashPassword(password);

        public string Salt(string hash) => hash.Substring(0, 30);
    }
}
