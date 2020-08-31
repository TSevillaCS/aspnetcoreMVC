using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MVCapp.Models
{
	public class StoreContext : DBContext
	{
		public StoreContext(DBContextOptions<StoreContext> options): base(options)
		{ }
		
		public DbSet<Customer> Customer {get; set;}
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
			}
		}
		
		public override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Teacher>(
			{
				entity.Property(e => e.FirstName)
					.IsRequired()
					.HasMaxLength(100)
				
				entity.Property(e=> e.LastName)
					.IsRequired()
					.HasMaxLength(100)
				
				entity.Property(e=> e.Email)
					.IsRequired()
					.HasMaxLength(100)
			});
		}
		
		
	}
}
