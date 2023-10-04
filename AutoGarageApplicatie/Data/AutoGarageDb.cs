using AutoGarageApplicatie.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoGarageApplicatie.Data
{
    public class AutoGarageDb : DbContext
    {
        public DbSet<Owner> Owner { get; set; }
        public DbSet<Car> Car { get; set; }

        public AutoGarageDb(DbContextOptions<AutoGarageDb> contextOptions)
            : base(contextOptions)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
