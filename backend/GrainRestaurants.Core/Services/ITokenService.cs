using GrainRestaurants.Core.Entities;
using System.Security.Claims;

namespace GrainRestaurants.Core.Services
{
    public interface ITokenService
    {
        string GenerateAccessToken(User user);
        string GenerareRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
