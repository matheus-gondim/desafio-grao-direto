using GrainRestaurants.Core.DTOs.Response;
using GrainRestaurants.Core.Entities;
using GrainRestaurants.Core.Exceptions;
using GrainRestaurants.Core.Repositories;
using GrainRestaurants.Core.Services;
using System.Collections.Generic;
using System.Linq;

namespace GrainRestaurants.Application.Services
{
    public class DishService : IDishService
    {
        private readonly IDishRepository _dishRepository;

        public DishService(IDishRepository dishRepository)
        {
            _dishRepository = dishRepository;
        }

        public List<Dish> FindDishByRestaurantId(long restaurantId)
        {
            if (restaurantId <= 0)
                throw new BadRequestException("Id do restaurante é obrigatório.");

            return _dishRepository.FindDishByRestaurantId(restaurantId);
        }
    }
}
