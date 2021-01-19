using Colonize.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Colonize.Data
{

    public class ColonizeContext : IdentityDbContext
    {

        public DbSet<Ship> Ship { get; set; }
        public DbSet<Voyage> Voyage { get; set; }



        public ColonizeContext(DbContextOptions<ColonizeContext> options)
        : base(options)
        {


        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}