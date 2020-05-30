using System;
using ETT.DAL.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ETT.DAL.Test
{
    [TestClass]
    public class EntitiyFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDAL productDAL = new EfProductDAL();//asla newlenmez ama testte newlenir
            var result = productDAL.GetList();
            Assert.AreEqual(77, result.Count);
        }
        [TestMethod]
        public void Get_all_with_parameter_returns_filtered_products()
        {
            EfProductDAL productDAL = new EfProductDAL();//asla newlenmez ama testte newlenir
            var result = productDAL.GetList(p=>p.ProductName.Contains("ab"));
            Assert.AreEqual(4, result.Count);
        }
    }
}
