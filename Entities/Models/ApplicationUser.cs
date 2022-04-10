using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Entities.Models;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [Required]
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    [Required]
    public string LastName { get; set; }
    public string? SecondLastName { get; set; }

    //public List<Clases> Clases { get; set; }
}

