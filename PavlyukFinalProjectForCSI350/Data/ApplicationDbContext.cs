using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using PavlyukFinalProjectForCSI350.Models;

namespace PavlyukFinalProjectForCSI350.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PavlyukFinalProjectForCSI350.Models.Coffee> Coffee { get; set; }
        public DbSet<PavlyukFinalProjectForCSI350.Models.SignUpResponces> SignUpResponces { get; set; }
    }
}
