using GrainRestaurants.API.Util;
using GrainRestaurants.Core.DTOs.Request;
using GrainRestaurants.Core.DTOs.Response;
using GrainRestaurants.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace GrainRestaurants.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("sign-up")]
        [ProducesResponseType(201, Type = typeof(ResponseObject<UserAndTokenResponseDto>))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public IActionResult SignUp([FromBody] SignUpRequestDto dto)
        {
            var userAndToken = _authService.SignUp(dto);
            return Created("auth/", new ResponseObject<UserAndTokenResponseDto>(userAndToken));
        }

        [HttpPost("sign-in")]
        [ProducesResponseType(201, Type = typeof(ResponseObject<UserAndTokenResponseDto>))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [ProducesResponseType(500)]
        public IActionResult SignIn([FromBody] SignInResquestDto dto)
        {
            var userAndToken = _authService.SignIn(dto);
            return Created("auth/", new ResponseObject<UserAndTokenResponseDto>(userAndToken));
        }
    }
}
