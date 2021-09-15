using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelApi.Domain;

namespace HotelApi.Data
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
		{}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Country>().HasData(
				new Country
				{
					Id = 1,
					Name = "any_name_1",
					ShortName = "any_short_name_1"
				},
				new Country
				{
					Id = 2,
					Name = "any_name_2",
					ShortName = "any_short_name_2"
				},
				new Country
				{
					Id = 3,
					Name = "any_name_3",
					ShortName = "any_short_name_3"
				}
			);


			builder.Entity<Hotel>().HasData(
				new Hotel
				{
					Id = 1,
					Name = "any_name_1",
					Address = "any_address_1",
					CountryId = 1,
					Rating = 2.5
				},
				new Hotel
				{
					Id = 2,
					Name = "any_name_2",
					Address = "any_address_2",
					CountryId = 2,
					Rating = 4.5
				},
				new Hotel
				{
					Id = 3,
					Name = "any_name_3",
					Address = "any_short_name_3",
					CountryId = 1,
					Rating = 3.5
				}
			);
		}

		public DbSet<Country> Countries { get; set; }

		public DbSet<Hotel> Hotels { get; set; }
	}
}
