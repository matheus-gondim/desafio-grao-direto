using GrainRestaurants.Core.Entities.Contratc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrainRestaurants.Core.Entities
{

    public class BaseEntity : IBaseEntity
    {
        [Key]
        [Column("Id")]
        public long Id { get; set; }
    }
}
