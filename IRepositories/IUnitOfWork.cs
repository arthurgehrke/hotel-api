using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.Data;

namespace HotelApi.IRepositories
{
	public interface IUnitOfWork : IDisposable
	{
		IGenericRepository<Country> Countries { get; }
		IGenericRepository<Hotel> Hotels { get; }
		Task Save();
	}
}
