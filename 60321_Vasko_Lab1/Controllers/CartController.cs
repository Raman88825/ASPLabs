using _60321_Vasko_Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLabs_V2.DAL.Entities;
using WebLabs_V2.DAL.Interfaces;

namespace _60321_Vasko_Lab1.Controllers
{
    public class CartController : Controller
    {        
        private IRepository<Dish> repository;

        public CartController(IRepository<Dish> repo)
        {
            repository = repo;
        }

        // GET: Cart
        [Authorize]
        public ActionResult IndexCart(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return View(GetCart());
        }

        // получение корзины из сессии
        public Cart GetCart()
        {
            Cart cart = Session["Cart"] as Cart;
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }

        // добавление товара в корзину
        public RedirectResult AddToCart(int id, string returnUrl)
        {
            var item = repository.Get(id);
            if (item != null)
            {
                GetCart().AddItem(item);
            }

            return Redirect(returnUrl);
        }

        public PartialViewResult CartSummary(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return PartialView(GetCart());
        }
    }
}