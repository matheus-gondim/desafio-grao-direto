using System;
using System.Collections.Generic;

namespace GrainRestaurants.Core.DTOs.Shared
{
    public class ErrorResponse
    {
        public DateTime Timestamp { get; set; }
        public int Status { get; set; }
        public string Error { get; set; }
        public List<string> Messages { get; set; }
    }
}
