using System;
using Microsoft.EntityFrameworkCore;
using PuWeb.Data.Entities;

namespace PuWeb.Data
{
    public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext()
		{
		}

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<BodyStyle> BodyStyles { get; set; }

        public DbSet<CarExtras> CarExtras { get; set; }

        public DbSet<CarLevel> CarLevels { get; set; }

        public DbSet<CarMake> CarMakes { get; set; }

        public DbSet<CarTunings> CarTunings { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<Condition> Conditions { get; set; }

        public DbSet<Extra> Extras { get; set; }

        public DbSet<FuelType> FuelTypes { get; set; }

        public DbSet<Tuning> Tunings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=puweb;User Id=sa;Password=reallyStrongPwd123;");
            }
        }
    }
}

