using GrainRestaurants.Core.Entities.Contratc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GrainRestaurants.Core.Entities
{
    [Table("Dish")]
    public class Dish : BaseEntity, ICreatedAt
    {
        public Dish() { }

        [Required] public string Name { get; set; }
        [Required] public double Price { get; set; }
        [Required] public DateTime CreatedAt { get; set; }
        [Required] public long RestaurantId { get; set; }
        [Required] public string Description { get; set; }
        [Required] public string ImageUrl { get; set; }

        [JsonIgnore] public Restaurant Restaurant { get; set; }
    }
}
