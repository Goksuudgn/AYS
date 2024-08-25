using AYS.Data;
using AYS.Models;
using AYS.Repository.Shared.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AYS.Repository.Shared.Concrate
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

		public T Add(T entity)
		{
			_dbSet.Add(entity);
			Save();
			return entity;
		}
		public List<T> AddRange(List<T> entities)
		{
			_dbSet.AddRange(entities);
            Save();
            return entities;
		}
		public void Delete(int id)
		{
			T entity = _dbSet.Find(id);
			entity.IsDeleted = true;
			_dbSet.Update(entity);
			Save();

		}
		public IEnumerable<T>GetAll()
		{
			return _dbSet.Where(x => !x.IsDeleted).ToList();
		}
		public T GetById(int id)
		{
			return _dbSet.Find(id);
		}
		public T GetFirstOrDefault(Expression<Func<T, bool>> predicate)
		{
			return _dbSet.FirstOrDefault(predicate);
		}
		public void Save()
		{
			_context.SaveChanges();
		}
		public T Update(T entity)
		{
		    _dbSet.Update(entity);
			Save();
			return entity;
		}

	}

	
}
