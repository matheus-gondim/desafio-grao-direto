using GrainRestaurants.Core.DTOs.Request;
using GrainRestaurants.Core.Entities;
using GrainRestaurants.Core.Paginated;

namespace GrainRestaurants.Core.Services
{
    public interface IRestaurantService
    {
        Page<Restaurant> FindRestaurantWithFilter(FilterRestaurantRequestDto dto);
        Restaurant FindRestaurantById(long id);
    }
}
