using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class User : IdentityUser
    {
        public List<CustomCollection> Collections { get; set; } = new List<CustomCollection>();
    }
}
