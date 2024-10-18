using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.DTOs
{
    public class UpdateProfileModel
    {
        public string? Email { get; set; } = null!;
    public string? FullName { get; set; } = null!;
    public string? Password { get; set; } = null!;
    public string? ContactInfo { get; set; } = null!;

    // Restricted fields 
    public string? Role { get; set; }       = null!;
    public List<Rating>? Ratings { get; set; }  = null!;
    public List<Order>? Orders { get; set; }  = null!;
    }
}