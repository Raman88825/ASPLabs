using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ninject;
using Ninject.Web.Common.WebHost;
using WebLabs_V2.DAL.Interfaces;
using WebLabs_V2.DAL.Repositories;
using WebLabs_V2.DAL.Entities;

namespace _60321_Vasko_Lab1
{
    public class MvcApplication : NinjectHttpApplication // System.Web.HttpApplication
    {        

        protected override void OnApplicationStarted()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected override IKernel CreateKernel()
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IRepository<Dish>>().To<EFDishRepository>().WithConstructorArgument("name", "FoodConnection");

            return kernel;
        }
    }
}
