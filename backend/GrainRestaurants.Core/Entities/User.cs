using GrainRestaurants.Core.DTOs.Request;
using GrainRestaurants.Core.Entities.Contratc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GrainRestaurants.Core.Entities
{
    [Table("User")]
    public class User : BaseEntity, ITimeTrack
    {
        public User() { }
        public User(SignUpRequestDto dto)
        {
            Name = dto.Name;
            Email = dto.Email;
            CreatedAt = DateTime.Now.ToLocalTime();
        }

        [Required] public string Name { get; set; }
        [Required] public string Email { get; set; }
        public string? RefreshToken { get; set; }
        [Required] public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        [JsonIgnore] public ICollection<Password> Passwords { get; set; }
    }
}
