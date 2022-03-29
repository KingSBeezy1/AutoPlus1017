using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoPlus1017.Entities
{
    public class Users : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public int EGN { get; set; }
        public DateTime RegistrationDate { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
