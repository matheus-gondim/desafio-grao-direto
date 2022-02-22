using GrainRestaurants.Core.Entities;
using GrainRestaurants.Core.Repositories;
using System.Linq;

namespace GrainRestaurants.Infrastructure.Repositories
{
    public class PasswordRepository : GenericRepository<Password>, IPasswordRepository
    {
        public PasswordRepository(GrainRestaurantDBContext context) : base(context) { }

        public Password FindCurrentPasswordByUserId(long userId)
        {
            return _dataset.Where(p => p.UserId.Equals(userId))
                .OrderByDescending(p => p.CreatedAt)
                .First();
        }
    }
}
