using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer
{
	public class LabDbContext : DbContext
	{
		public LabDbContext() : base()
		{

		}

		public LabDbContext(DbContextOptions contextOptions) : base(contextOptions)
		{

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Server=DESKTOP-F3IKLD2;Database=Shop11JDb;Trusted_Connection=True;");
			}

			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<Colony> colonies { get; set; }	

		public DbSet<Cupboard> cupboard { get; set; }

		public DbSet<PetriDish> petridish { get; set; }
	}
}
