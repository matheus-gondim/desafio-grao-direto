using GrainRestaurants.Core.DTOs.Request;
using GrainRestaurants.Core.Entities;
using GrainRestaurants.Core.Paginated;

namespace GrainRestaurants.Core.Repositories
{
    public interface IRestaurantRepository : IGenericRepository<Restaurant>
    {
        Page<Restaurant> FindRestaurantWithFilter(FilterRestaurantRequestDto dto);
        public Restaurant? FindRestaurantById(long id);

    }
}
