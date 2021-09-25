using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HotelApi.IRepositories
{
	public interface IGenericRepository<T> where T : class
	{
		Task<IList<T>> GetAll(
			Expression<Func<T, bool>> expression = null,
			Func<IQueryable<T>>, IOrderedQueryable<T>> orderBy = null,
			List<string> includes = null
		);

		Task<T> Get(
			Expression<Func<T, bool>> expresion = null,
			List<string> includes = null
		);

		Task Insert(T entity);

		Task InsertRange(IEnumerable<T> entities);

		Void Update(T entity);

		Task Delete(int id);

		Void DeleteRange(IEnumerable<T> entitiesId);
	}
}
