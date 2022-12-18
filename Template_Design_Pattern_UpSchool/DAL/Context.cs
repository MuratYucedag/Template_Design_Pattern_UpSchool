using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_Design_Pattern_UpSchool.DAL.Entites;

namespace Template_Design_Pattern_UpSchool.DAL
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-07T8MF2\\MSSQLSERVER01;initial catalog=UpSchoolTemplateDb;integrated security=true");
        }


    }
}
