using GrainRestaurants.Core.Config;
using GrainRestaurants.Core.DTOs.Request;
using GrainRestaurants.Core.DTOs.Response;
using GrainRestaurants.Core.Entities;
using GrainRestaurants.Core.Services;
using System;

namespace GrainRestaurants.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly TokenConfiguration _configuration;
        private readonly IUserService _userService;
        private readonly ITokenService _tokenService;

        public AuthService(IUserService userService, ITokenService tokenService)
        {
            _configuration = new TokenConfiguration();
            _userService = userService;
            _tokenService = tokenService;
        }

        public UserAndTokenResponseDto SignUp(SignUpRequestDto dto)
        {
            var user = _userService.CreateUser(dto);
            return GenerateTokenAndRefreshToken(user);
        }

        public UserAndTokenResponseDto SignIn(SignInResquestDto dto)
        {
            var user = _userService.ValidateCredentials(dto);
            return GenerateTokenAndRefreshToken(user);
        }


        private UserAndTokenResponseDto GenerateTokenAndRefreshToken(User user)
        {
            var accessToken = _tokenService.GenerateAccessToken(user);
            var refreshToken = _tokenService.GenerareRefreshToken();

            _userService.UpdateRefreshToken(user, refreshToken);

            DateTime createDate = DateTime.Now;
            DateTime expirationDate = createDate.AddMinutes(_configuration.DaysToExpiry);

            return new UserAndTokenResponseDto
            {
                Created = createDate,
                Expiration = expirationDate,
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                User = user
            };
        }
    }
}
