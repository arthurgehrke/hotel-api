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

		public DbSet<Country> Countries { get; set; }

		public DbSet<Hotel> Hotels { get; set; }
	}
}
