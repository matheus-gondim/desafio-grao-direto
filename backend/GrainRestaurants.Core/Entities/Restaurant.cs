using GrainRestaurants.Core.Entities.Contratc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrainRestaurants.Core.Entities
{
    [Table("Restaurant")]
    public class Restaurant : BaseEntity, ITimeTrack
    {
        public Restaurant() { }

        [Required] public string FederalDocument { get; set; }
        [Required] public string Name { get; set; }
        [Required] public long RestaurantTypeId { get; set; }
        [Required] public double Score { get; set; }
        [Required] public string Phone { get; set; }
        [Required] public bool IsOpen { get; set; }
        [Required] public long AddressId { get; set; }
        [Required] public string ImageUrl { get; set; }
        public string? Resume { get; set; }


        [Required] public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public ICollection<Dish> Menu { get; set; }
        public RestaurantType Type { get; set; }
        public Address Address { get; set; }
    }
}
