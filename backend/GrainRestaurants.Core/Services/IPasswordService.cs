using GrainRestaurants.Core.Entities;

namespace GrainRestaurants.Core.Services
{
    public interface IPasswordService
    {
        Password CreatePassword(string password);
        bool CheckPassword(long userId, string password);
    }
}
