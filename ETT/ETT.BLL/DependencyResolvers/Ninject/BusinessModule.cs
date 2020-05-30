
using ETT.BLL.Abstract;
using ETT.BLL.Concrete.Managers;
using ETT.DAL.Abstract;
using ETT.DAL.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETT.BLL.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDAL>().To<EfProductDAL>().InSingletonScope();


            Bind<DbContext>().To<NorthwindContext>();
   
        }
    }
}
