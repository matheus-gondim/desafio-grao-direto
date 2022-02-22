using GrainRestaurants.Core.Paginated;
using System.ComponentModel.DataAnnotations;

namespace GrainRestaurants.Core.DTOs.Request
{
    public class FilterRestaurantRequestDto : Pageable
    {
        [
            StringLength(maximumLength: 250, MinimumLength = 1, ErrorMessage = "Nome de usuário deve ter entre 3 a 250 caracteres."),
        ]
        public string Name { get; set; }
    }
}
