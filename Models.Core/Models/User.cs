using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Core.Models
{
    public class User : IdentityUser
    {
        public string? Address { get; set; }
        public string? Region { get; set; }
    }
}
