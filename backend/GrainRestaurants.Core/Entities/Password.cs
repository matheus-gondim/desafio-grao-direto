using GrainRestaurants.Core.Entities.Contratc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrainRestaurants.Core.Entities
{
    [Table("Password")]
    public class Password : BaseEntity, ICreatedAt
    {
        [Required] public string Hash { get; set; }
        [Required] public string Salt { get; set; }
        [Required] public long UserId { get; set; }
        [Required] public DateTime CreatedAt { get; set; }


        public User User { get; set; }
    }
}
