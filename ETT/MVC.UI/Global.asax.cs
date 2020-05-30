using DevFramework.NorthWind.Business.DependencyResolvers.Ninject;
using ETT.BLL.DependencyResolvers.Ninject;
using ETT.Core.Utilities.Mvc.Infrastructure;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVC.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {

  
        protected void Application_Start()
        {
            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory(new BusinessModule(), new AutoMapperModule()));
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
