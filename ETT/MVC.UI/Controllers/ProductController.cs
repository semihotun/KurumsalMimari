using ETT.BLL.Abstract;
using MVC.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index(int id=1)
        {
            var model = new ProductListViewModel
            {
                Products = _productService.GetAll()
             };

            var deneme = _productService.GetById(1);
            return View(model);
        }
    }
}