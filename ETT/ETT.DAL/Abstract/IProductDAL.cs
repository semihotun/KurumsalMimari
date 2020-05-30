using ETT.Core.DataAccess;
using ETT.Entities.ComplexTypes;
using ETT.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETT.DAL.Abstract
{
    public interface IProductDAL:IEntitiyRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
    }
}
