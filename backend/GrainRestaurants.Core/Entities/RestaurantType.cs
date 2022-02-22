using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GrainRestaurants.Core.Entities
{
    [Table("RestaurantType")]
    public class RestaurantType : BaseEntity
    {
        [Required] public string Name { get; set; }


        [JsonIgnore] public ICollection<Restaurant> Restaurant { get; set; }
    }
}
