using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.EntityFrameworkRepositoryPattern.Interface;

namespace Udemy.EntityFrameworkRepositoryPattern.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class, new()
    {
        public EFContext Context { get; set; }

        public DbSet<T> Table { get; set; }

        public RepositoryBase()
        {
            Context=new EFContext();

            //İlgili DbSet'i Table'a atadık.
            Table = Context.Set<T>();
        }


        public bool Any(System.Linq.Expressions.Expression<Func<T, bool>> filter = null)
        {
            return filter==null ? Table.Any() : Table.Any(filter);
        }

        public int Count(System.Linq.Expressions.Expression<Func<T, bool>> filter = null)
        {
            return filter==null ? Table.Count() :Table.Count(filter);
        }

        public void CUDOperation(T Entity, EntityState state)
        {
            //enumdan Aldığı değerlere göre işlem yapılacak
            Context.Entry(Entity).State = state;

        }

        public T Find(Guid ID)
        {
            return Table.Find(ID);
        }

        public T First(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            return filter == null ? Table.First() : Table.First(filter);
        }

        public IEnumerable<T> GetAll()
        {
            return Table.ToList();
        }

        public int SaveChange()
        {
            return Context.SaveChanges();
        }

        public IQueryable<TResult> Select<TResult>(System.Linq.Expressions.Expression<Func<T, TResult>> selector)
        {
            return Table.Select(selector);
        }

        public IQueryable<TResult> Select<TResult>(System.Linq.Expressions.Expression<Func<T, bool>> filter, System.Linq.Expressions.Expression<Func<T, TResult>> selector)
        {
            return Table.Where(filter).Select(selector);
        }

        public IQueryable<T> Where(System.Linq.Expressions.Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            return orderBy == null ? Table.Where(filter) : orderBy(Table.Where(filter));
        }
    }
}
