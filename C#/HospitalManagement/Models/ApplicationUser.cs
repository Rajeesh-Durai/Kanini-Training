﻿using Microsoft.AspNetCore.Identity;

namespace HospitalManagement.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}
