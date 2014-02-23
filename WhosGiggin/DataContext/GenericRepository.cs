using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using WhosGiggin.Models;

namespace WhosGiggin.DataContext
{
    public class GenericRepository<T> : IWhosGigginRepository<T> where T : class
    {
        private readonly DatabaseContext _context;
       private readonly DbSet<T> _dbSet;
       public GenericRepository(DatabaseContext context)
       {
            _context = context;
            _dbSet = _context.Set<T>();
    }
        public IQueryable<T> All
        {
            get { return _dbSet.AsQueryable(); }
        }

        public IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbSet;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public virtual IEnumerable<T> Get(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<T> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
        public T Find(int id)
        {
            return _dbSet.Find(id);
        }

        public void InsertOrUpdate(IIdentifiableObject model)
        {
            var entity = model as T;
            if (model.Id == default(int))
            {
                // New entity
                _dbSet.Add(entity);
            }
            else
            {
                // Existing entity
                _dbSet.Attach(entity);
                _context.Entry(entity).State =System.Data.Entity.EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var model = _dbSet.Find(id);
            _dbSet.Remove(model);
        }
        public virtual void Delete(T entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == System.Data.Entity.EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }
            _dbSet.Remove(entityToDelete);

        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}