using ETT.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETT.Core.DataAccess
{
    public interface IEntitiyRepository<T> where T:class,IEntitiy,new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        T Add(T entitiy);
        T Update(T entitiy);
        void Delete(T entitiy);
    }
}
