using GrainRestaurants.Core.Config;
using GrainRestaurants.Core.Entities;
using GrainRestaurants.Core.Services;
using GrainRestaurants.Core.Util;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GrainRestaurants.Application.Services
{
    public class TokenService : ITokenService
    {
        private readonly TokenConfiguration _configuration;
        private readonly ICryptography _cryptography;

        public TokenService(ICryptography cryptography)
        {
            _configuration = new();
            _cryptography = cryptography;
        }

        public string GenerareRefreshToken() => _cryptography.GenerareToken();

        public string GenerateAccessToken(User user)
        {
            List<Claim> claims = new()
            {
                new(JwtRegisteredClaimNames.Email, user.Email),
                new(JwtRegisteredClaimNames.Sub, user.Id.ToString())
            };

            var sercretKey = GetSecurityKey();

            var signinCredentials = new SigningCredentials(sercretKey, SecurityAlgorithms.HmacSha256);

            var options = new JwtSecurityToken(
                issuer: _configuration.Issuer,
                claims: claims,
                expires: DateTime.Now.AddDays(_configuration.DaysToExpiry),
                signingCredentials: signinCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(options);
        }

        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = GetSecurityKey(),
                ValidateLifetime = false
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            ClaimsPrincipal principal = tokenHandler
                .ValidateToken(token, tokenValidationParameters, out SecurityToken securityToken);

            var jwtSecurityToken = securityToken as JwtSecurityToken;
            var isValidAlgorithms = jwtSecurityToken.Header.Alg
                .Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCulture);

            if (jwtSecurityToken is null || !isValidAlgorithms)
                throw new SecurityTokenException("Token inválido.");

            return principal;
        }

        private SymmetricSecurityKey GetSecurityKey() => new(Encoding.UTF8.GetBytes(_configuration.Secret));
    }
}
