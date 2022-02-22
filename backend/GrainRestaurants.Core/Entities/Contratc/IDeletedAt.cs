using System;

namespace GrainRestaurants.Core.Entities.Contratc
{
    public interface IDeletedAt
    {
        public DateTime? DeletedAt { get; set; }
    }
}
