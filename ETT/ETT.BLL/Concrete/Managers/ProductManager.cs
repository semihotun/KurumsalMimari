using ETT.BLL.Abstract;
using ETT.BLL.ValidationRules;
using ETT.Core.CrossCuttingConcern.Validation.FluentValidation;
using ETT.DAL.Abstract;
using ETT.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ETT.BLL.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDAL _productDal;
        public ProductManager(IProductDAL productDal)
        {
            _productDal = productDal;
        }
        //[FluentValidationAspect(typeof(ProductValidator))]
        public Product Add(Product product)
        {
        

            return _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }
        //[FluentValidationAspect(typeof(ProductValidator))]
        public Product Update(Product product)
        {

            return _productDal.Update(product);
        }
    }
}
