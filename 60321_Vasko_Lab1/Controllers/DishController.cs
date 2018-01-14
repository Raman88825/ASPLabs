using _60321_Vasko_Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebLabs_V2.DAL.Entities;
using WebLabs_V2.DAL.Interfaces;

namespace _60321_Vasko_Lab1.Controllers
{
    public class DishController : Controller
    {
        int pageSize = 3;
        IRepository<Dish> repository;
        public DishController(IRepository<Dish> repo)
        {
            repository = repo;
        }

        // GET: Dish        
        public ActionResult List(string group, int page = 1)
        {
            var lst = repository.GetAll()
                .Where(d => group == null || d.GroupName.Equals(group))
                .OrderBy(d => d.Calories);

            var model = PageListViewModel<Dish>.CreatePage(lst, page, pageSize);

            if (Request.IsAjaxRequest())
            {
                return PartialView("ListPartial", model);
            }
            return View(model);
        }

        public FileContentResult GetImage(int id)
        {
            var dish = repository.Get(id);
            if (dish.Image != null)
            {
                return File(dish.Image, dish.MimeType);
            }
            else return null;
        }

        public async Task<FileResult> GetImageAsync(int id)
        {
            var dish = await repository.GetAsync(id);
            if (dish.Image != null)
            {
                return File(dish.Image, dish.MimeType);
            }
            else return null;
        }
    }
}