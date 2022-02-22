using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GrainRestaurants.Core.Entities
{
    public class Address : BaseEntity
    {
        public Address() { }

        [Required] public string PostalCode { get; set; }
        public string Location { get; set; }
        public string Number { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Uf { get; set; }
        public string AdditionalInfo { get; set; }
        public string Country { get; set; }

        [JsonIgnore] public ICollection<Restaurant> Restaurants { get; set; }
    }
}
