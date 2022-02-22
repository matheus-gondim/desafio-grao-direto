using GrainRestaurants.Core.Entities;

namespace GrainRestaurants.Core.Repositories
{
    public interface IPasswordRepository : IGenericRepository<Password>
    {
        Password FindCurrentPasswordByUserId(long userId);
    }
}
