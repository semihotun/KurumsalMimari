using ETT.Core.DataAccess.EntitiyFramework;
using ETT.DAL.Abstract;
using ETT.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETT.DAL.Concrete.EntitiyFramework
{
   public class EfCategoryDAL: EfEntitiyRepositoryBase<Category, NorthwindContext>, ICategoryDAL
    {
    }
}
