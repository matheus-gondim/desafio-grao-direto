using GrainRestaurants.Core.Entities;
using System.Collections.Generic;

namespace GrainRestaurants.Core.Repositories
{
    public interface IDishRepository : IGenericRepository<Dish>
    {
        List<Dish> FindDishByRestaurantId(long restaurantId);
    }
}
