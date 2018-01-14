using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using WebLabs_V2.DAL.Entities;
using WebLabs_V2.DAL.Interfaces;
using WebLabs_V2.DAL.Repositories;

namespace _60321_Vasko_Lab1.Services
{
    public class NinjectDependencyresolver : IDependencyResolver
    {
        IKernel kernel;
        public NinjectDependencyresolver()
        {
            kernel = new StandardKernel();
            kernel.Bind<IRepository<Dish>>().To<EFDishRepository>().WithConstructorArgument("name", "FoodConnection");
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}