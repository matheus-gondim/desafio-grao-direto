using GrainRestaurants.Core.DTOs.Request;
using GrainRestaurants.Core.Entities;
using GrainRestaurants.Core.Exceptions;
using GrainRestaurants.Core.Paginated;
using GrainRestaurants.Core.Repositories;
using GrainRestaurants.Core.Services;

namespace GrainRestaurants.Application.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public Page<Restaurant> FindRestaurantWithFilter(FilterRestaurantRequestDto dto)
        {
            return this._restaurantRepository.FindRestaurantWithFilter(dto);
        }

        public Restaurant FindRestaurantById(long id)
        {
            if (id <= 0) throw new BadRequestException("Id do restaurante é obrigatório.");
            var restaurant = _restaurantRepository.FindRestaurantById(id);
            if (restaurant is null) throw new NotFoundException("Restaurante não encontrado");
            return restaurant;
        }
    }
}
