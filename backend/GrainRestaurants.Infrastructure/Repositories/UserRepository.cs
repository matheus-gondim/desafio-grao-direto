using GrainRestaurants.Core.Entities;
using GrainRestaurants.Core.Repositories;

namespace GrainRestaurants.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(GrainRestaurantDBContext context) : base(context) { }
    }
}
