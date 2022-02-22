using GrainRestaurants.Core.Entities;
using System;

namespace GrainRestaurants.Core.DTOs.Response
{
    public class UserAndTokenResponseDto
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public User User { get; set; }
        public DateTime Expiration { get; set; }
        public DateTime Created { get; set; }
    }
}
