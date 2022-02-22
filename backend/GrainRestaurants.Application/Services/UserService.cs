using GrainRestaurants.Core.DTOs.Request;
using GrainRestaurants.Core.Entities;
using GrainRestaurants.Core.Exceptions;
using GrainRestaurants.Core.Repositories;
using GrainRestaurants.Core.Services;
using System.Collections.Generic;

namespace GrainRestaurants.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordService _passwordService;

        public UserService(IUserRepository userRepository, IPasswordService passwordService)
        {
            _userRepository = userRepository;
            _passwordService = passwordService;
        }

        public User CreateUser(SignUpRequestDto dto)
        {
            User newUser = new(dto);
            var password = _passwordService.CreatePassword(dto.Password);
            newUser.Passwords = new List<Password> { password };
            return _userRepository.Save(newUser);
        }

        public User UpdateRefreshToken(User user, string refreskToken)
        {
            user.RefreshToken = refreskToken;
            return _userRepository.Update(user);
        }

        public User ValidateCredentials(SignInResquestDto dto)
        {
            var user = _userRepository.FindBy(u => u.Email.Equals(dto.Email));
            if (user is null)
            {
                throw new NotFoundException("Usuário com esse email não encontrado.");
            }

            var isValidPassword = _passwordService.CheckPassword(user.Id, dto.Password);
            if (!isValidPassword) throw new UnauthorizedException("Senha inválida.");

            return user;
        }

    }
}
