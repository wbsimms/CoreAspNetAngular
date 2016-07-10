using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CoreAspNetAngular.DataAccess.Data;
using CoreAspNetAngular.DataAccess.Models;

namespace CoreAspNetAngular.DataAccess.Repositories
{
	public interface IRepositoryBase<T> where T : Entity
	{
		IQueryable<T> GetAll();
		IQueryable<T> Get(Expression<Func<T, bool>> expression);
		T Add(T entity);
		IEnumerable<T> AddRange(IEnumerable<T> entities);
	}

	public class RepositoryBase<T> : IRepositoryBase<T> where T : Entity
	{
		protected ApplicationDbContext context;

		public IEnumerable<T> AddRange(IEnumerable<T> entities)
		{
			context.Set<T>().AddRange(entities);
			context.SaveChanges();
			return entities;
//			return context.Set<T>().AddRange(entities);
		}

		public T Add(T entity)
		{
			context.Set<T>().Add(entity);
			context.SaveChanges();
			return entity;
		}

		public IQueryable<T> GetAll()
		{
			return context.Set<T>();
		}

		public IQueryable<T> Get(Expression<Func<T, bool>> expression)
		{
			return context.Set<T>().Where(expression);
		}
		public RepositoryBase(ApplicationDbContext dataAccessContext)
		{
			this.context = dataAccessContext;
		}
	}
}
