using ETT.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETT.Core.DataAccess
{
    public interface IQueryable<T> where T:class,IEntitiy,new()
    {

        IQueryable Table { get; }
    }
}
