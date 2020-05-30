using ETT.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETT.Core.DataAccess.EntitiyFramework
{
    public class EfEntitiyRepositoryBase<TEntitiy, TContext> : IEntitiyRepository<TEntitiy>
         where TEntitiy : class, IEntitiy, new()
         where TContext : DbContext, new()
    {
        public TEntitiy Add(TEntitiy entitiy)
        {
            using (var context = new TContext())
            {
                var addEntitiy = context.Entry(entitiy);
                addEntitiy.State = EntityState.Added;
                context.SaveChanges();
                return entitiy;
            }
        }

        public void Delete(TEntitiy entitiy)
        {
            using (var context = new TContext())
            {
                var deletedEntitiy = context.Entry(entitiy);
                deletedEntitiy.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntitiy Get(Expression<Func<TEntitiy, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntitiy>().SingleOrDefault(filter);
            }
        }

        public List<TEntitiy> GetList(Expression<Func<TEntitiy, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntitiy>().ToList()
                    : context.Set<TEntitiy>().Where(filter).ToList();
            }
        }

        public TEntitiy Update(TEntitiy entitiy)
        {
            using (var context = new TContext())
            {
                var updatedEntitiy = context.Entry(entitiy);
                updatedEntitiy.State = EntityState.Modified;
                context.SaveChanges();
                return entitiy;
            }
        }
    }
}
