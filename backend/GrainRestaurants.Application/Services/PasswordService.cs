using GrainRestaurants.Core.Entities;
using GrainRestaurants.Core.Repositories;
using GrainRestaurants.Core.Services;
using GrainRestaurants.Core.Util;
using System;

namespace GrainRestaurants.Application.Services
{
    public class PasswordService : IPasswordService
    {
        private readonly IPasswordRepository _passwordRepository;
        private readonly ICryptography _cryptography;

        public PasswordService(IPasswordRepository passwordRepository, ICryptography cryptography)
        {
            _passwordRepository = passwordRepository;
            _cryptography = cryptography;
        }

        public Password CreatePassword(string password)
        {
            var hash = _cryptography.Hash(password);
            var salt = _cryptography.Salt(hash);

            return new()
            {
                Hash = hash,
                Salt = salt,
                CreatedAt = DateTime.Now.ToLocalTime(),
            };
        }

        public bool CheckPassword(long userId, string password)
        {
            var currentPassword = _passwordRepository.FindCurrentPasswordByUserId(userId);
            return _cryptography.Compare(password: password, hash: currentPassword.Hash);
        }
    }
}
