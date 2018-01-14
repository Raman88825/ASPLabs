using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WebLabs_V2.DAL.Entities
{
    class FoodContext : DbContext
        {/// <summary>
        /// Конструктор класса
        /// </summary>
        ///// <param name="name"> имя строки подключения </param>
        public FoodContext(string name) : base(name)
        {
            Database.SetInitializer(new FoodContextInitializer());
        }

        public DbSet<Dish> Dishes { get; set; }
        }
    /*
        class FoodContextInitializer : CreateDatabaseIfNotExists<FoodContext>
    {
        protected override void Seed(FoodContext context)
        {
            List<Dish> dishes = new List<Dish>
        {
        new Dish {DishName="Суп-харчо", Description="Очень острый,невкусный",Calories =200, GroupName="Супы" },
        //new Dish {DishName="Борщ", Description="Много сала,без сметаны",    . . . И ТАК ДАЛЕЕ . . .
        new Dish {DishId=2, DishName="Борщ",Description="Много сала, без сметаны",Calories =330, GroupName="Супы" },
        new Dish {DishId=3, DishName="Котлета пожарская",Description="Хлеб - 80%, Морковь - 20%",Calories =635, GroupName="Вторые блюда" },
        new Dish {DishId=4, DishName="Макароны по-флотски",Description="С охотничьей колбаской",Calories =524, GroupName="Вторые блюда" },
        new Dish {DishId=5, DishName="Компот",Description="Быстро растворимый, 2 литра",Calories =180, GroupName="Напитки" }
        };
            context.Dishes.AddRange(dishes);
            context.SaveChanges(); 
        }
       
    }*/
}
