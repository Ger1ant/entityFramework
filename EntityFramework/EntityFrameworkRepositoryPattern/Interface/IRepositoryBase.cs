using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.EntityFrameworkRepositoryPattern.Interface
{
    //T 'nin bi class tipinde olduğu
    internal interface IRepositoryBase<T> where T : class, new()
    {
        T First(Expression<Func<T, bool>> filter);

        T Find(Guid ID);

        IQueryable<T> Where(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);

        bool Any(Expression<Func<T, bool>> filter = null);

        int Count(Expression<Func<T, bool>> filter = null);


        IQueryable<TResult> Select<TResult>(Expression<Func<T, TResult>> selector);

        IQueryable<TResult> Select<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector);

        IEnumerable<T> GetAll();

        //EntityState : Enum
        void CUDOperation(T Entity,EntityState state);

        int SaveChange();
    }
}