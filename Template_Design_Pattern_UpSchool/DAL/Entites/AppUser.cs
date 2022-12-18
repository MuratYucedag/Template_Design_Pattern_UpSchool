using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_Design_Pattern_UpSchool.DAL.Entites
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
