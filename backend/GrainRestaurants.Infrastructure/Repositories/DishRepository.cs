using GrainRestaurants.Core.Entities;
using GrainRestaurants.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace GrainRestaurants.Infrastructure.Repositories
{
    public class DishRepository : GenericRepository<Dish>, IDishRepository
    {
        public DishRepository(GrainRestaurantDBContext context) : base(context) { }

        public List<Dish> FindDishByRestaurantId(long restaurantId) => _dataset.Where(r => r.RestaurantId.Equals(restaurantId)).ToList();
    }
}
