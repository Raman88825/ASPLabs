using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _60321_Vasko_Lab1.Models;
using WebLabs_V2.DAL.Interfaces;
using WebLabs_V2.DAL.Entities;

namespace _60321_Vasko_Lab1.Controllers
{
    public class MenuController : Controller
    {
        IRepository<Dish> repository;

        List<MenuItem> items;
        public MenuController(IRepository<Dish> repo)
        {            
            items = new List<MenuItem>
            {
            new MenuItem{Name="Домой", Controller="Home",Action="Index", Active=string.Empty},
            new MenuItem{Name="Меню", Controller="Dish",Action="List", Active=string.Empty},
            //new MenuItem{Name="Каталог", Controller="Product",Action="List", Active=string.Empty},
            new MenuItem{Name="Администрирование", Controller="Admin",Action="Index", Active=string.Empty},
            };
            repository = repo;
        }

        //// GET: Menu
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public PartialViewResult Main(string a = "Index", string c = "Home")
        {
            //items.First(m => m.Controller == c).Active = "active";
            //return PartialView(items);
            var activeItem = items.FirstOrDefault(m => m.Controller == c);
            if (activeItem != null)
            {
                activeItem.Active = "active";
            }
            return PartialView(items);
        }

        public PartialViewResult UserInfo()
        {
            return PartialView();
        }
        public PartialViewResult Side()
        {
            var groups = repository.GetAll().Select(d => d.GroupName).Distinct();
            return PartialView(groups);
        }
        public PartialViewResult Map()
        {
            return PartialView(items);
        }
    }
}