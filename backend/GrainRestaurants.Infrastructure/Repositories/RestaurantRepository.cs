using GrainRestaurants.Core.DTOs.Request;
using GrainRestaurants.Core.Entities;
using GrainRestaurants.Core.Paginated;
using GrainRestaurants.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GrainRestaurants.Infrastructure.Repositories
{
    public class RestaurantRepository : GenericRepository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(GrainRestaurantDBContext context) : base(context) { }

        public Page<Restaurant> FindRestaurantWithFilter(FilterRestaurantRequestDto dto)
        {
            IQueryable<Restaurant> query = _dataset.Include(r => r.Type).Include(r => r.Menu)
                .Where(r => r.Name.ToUpper().Contains(dto.Name == null ? "" : dto.Name.ToUpper()) ||
                            r.Menu.Any(d => d.Name.ToUpper().Contains(dto.Name == null ? "" : dto.Name.ToUpper())) ||
                            r.Menu.Any(d => d.Description.ToUpper().Contains(dto.Name == null ? "" : dto.Name.ToUpper()))
                );

            dto.SortString?.ForEach(elem =>
            {
                query = elem.ToLower() switch
                {
                    "name_asc" => query.OrderBy(r => r.Name),
                    "name_desc" => query.OrderByDescending(r => r.Name),
                    "type_asc" => query.OrderBy(r => r.Type.Name),
                    "type_desc" => query.OrderByDescending(r => r.Type.Name),
                    "score_asc" => query.OrderBy(r => r.Score),
                    "score_desc" => query.OrderByDescending(r => r.Score),
                    _ => query.OrderBy(r => r.Id),
                };
            });

            int skip = (dto.Page - 1) * dto.PageSize;
            int totalElement = query.Count();

            var restaurants = query.Skip(skip).Take(dto.PageSize).ToList();
            return new(
                items: restaurants,
                currentPage: dto.Page,
                pageSize: dto.PageSize,
                totalItems: totalElement
                );
        }

        public Restaurant? FindRestaurantById(long id)
        {
            return _dataset.Include(r => r.Type)
                .Include(r => r.Address)
                .SingleOrDefault(r => r.Id.Equals(id));
        }
    }
}
