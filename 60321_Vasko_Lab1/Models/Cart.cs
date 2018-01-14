using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLabs_V2.DAL.Entities;

namespace _60321_Vasko_Lab1.Models
{
    public class Cart
    {
        List<CartItem> items;

        public Cart()
        {
            items = new List<CartItem>();
        }

        // добавить в корзину
        public void AddItem(Dish dish)
        {
            var item = items.Find(i => i.Dish.DishId == dish.DishId);
            if (item == null)
            {
                items.Add(new CartItem { Dish = dish, Qauntity = 1 });
            }
            else item.Qauntity += 1;
        }

        // удалить из корзины
        public void RemoveItem(Dish dish)
        {
            var item = items.Find(i => i.Dish.DishId == dish.DishId);
            if (item.Qauntity == 1)
            {
                items.Remove(item);
            }
            else
                item.Qauntity -= 1;
        }

        // очистить корзину
        public void Clear()
        {
            items.Clear();
        }

        // получение суммарной стоимости покупок
        public int GetTotal()
        {
            return items.Sum(i => i.Dish.Calories * i.Qauntity);
        }

        // получение содержимого корзины
        public IEnumerable<CartItem> GetItems()
        {
            return items;
        }
    }
}