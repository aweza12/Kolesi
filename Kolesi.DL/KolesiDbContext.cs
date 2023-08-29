using Kolesi.DL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Kolesi.DL
{
    public class KolesiDbContext : IdentityDbContext<User>
    {
        public DbSet<Bicycle> Bicycles { get; set; } = null!;
        public KolesiDbContext(DbContextOptions<KolesiDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Bicycle>().HasData(
                    new Bicycle { Id = Guid.NewGuid(), Name = "My"}
            );
        }
    }
}
