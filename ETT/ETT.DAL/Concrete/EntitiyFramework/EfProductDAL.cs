using ETT.Core.DataAccess.EntitiyFramework;
using ETT.DAL.Abstract;
using ETT.Entities.ComplexTypes;
using ETT.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETT.DAL.Concrete
{
    public class EfProductDAL : EfEntitiyRepositoryBase<Product, NorthwindContext>, IProductDAL
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.CategoryId
                             select new ProductDetail
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName
                             };
                return result.ToList();
            }
        }
    }
}
