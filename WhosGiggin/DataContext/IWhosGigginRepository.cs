using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using WhosGiggin.Models;

namespace WhosGiggin.DataContext
{
    public interface IWhosGigginRepository<T> : IDisposable
    {
        IQueryable<T> All { get; }
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        T Find(int id);
        void InsertOrUpdate(IIdentifiableObject model);
        void Delete(int id);
        void Save();
    }
}
