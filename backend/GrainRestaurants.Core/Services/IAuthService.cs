using GrainRestaurants.Core.DTOs.Request;
using GrainRestaurants.Core.DTOs.Response;

namespace GrainRestaurants.Core.Services
{
    public interface IAuthService
    {
        UserAndTokenResponseDto SignUp(SignUpRequestDto dto);
        UserAndTokenResponseDto SignIn(SignInResquestDto dto);
    }
}
