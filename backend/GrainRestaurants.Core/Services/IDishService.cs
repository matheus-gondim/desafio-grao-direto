using GrainRestaurants.Core.Entities;
using System.Collections.Generic;

namespace GrainRestaurants.Core.Services
{
    public interface IDishService
    {
        List<Dish> FindDishByRestaurantId(long restaurantId);
    }
}
