using GrainRestaurants.Core.DTOs.Request;
using GrainRestaurants.Core.Entities;

namespace GrainRestaurants.Core.Services
{
    public interface IUserService
    {
        User CreateUser(SignUpRequestDto dto);
        User UpdateRefreshToken(User user, string refreskToken);
        User ValidateCredentials(SignInResquestDto dto);
    }
}
