using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLabs_V2.DAL.Entities;

namespace _60321_Vasko_Lab1.Models
{
    public class CartItem
    {
        public Dish Dish { get; set; }
        public int Qauntity { get; set; }
    }
}