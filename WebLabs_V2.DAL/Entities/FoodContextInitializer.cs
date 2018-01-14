using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WebLabs_V2.DAL.Entities
{
    //class FoodContextInitializer : CreateDatabaseIfNotExists<FoodContext>
    class FoodContextInitializer : CreateDatabaseIfNotExists<FoodContext>
    //CreateDatabaseIfNotExists<FoodContext>

    //можно использовать класс DropCreateDatabaseAlways. В этом случае база данных будет создаваться заново при каждом запуске приложения
    {
        protected override void Seed(FoodContext context)
        {
            List<Dish> dishes = new List<Dish>
            {
                new Dish {DishId=1, DishName="Суп-харчо",Description="Очень острый, невкусный",Calories =200, GroupName="Супы" },
                new Dish {DishId=2, DishName="Борщ",Description="Много сала, без сметаны",Calories =330, GroupName="Супы" },
                new Dish {DishId=3, DishName="Котлета пожарская",Description="Хлеб - 80%, Морковь - 20%",Calories =635, GroupName="Вторые блюда" },
                new Dish {DishId=4, DishName="Макароны по-флотски",Description="С охотничьей колбаской",Calories =524, GroupName="Вторые блюда" },
                new Dish {DishId=5, DishName="Компот",Description="Быстро растворимый, 2 литра",Calories =180, GroupName="Напитки" },
                new Dish {DishId=5, DishName="Компот",Description="Быстро растворимый, 2 литра",Calories =180, GroupName="Напитки" },
                new Dish {DishId=6, DishName="Компот22",Description="Быстро растворимый, 2 литра",Calories =180, GroupName="Напитки" },
                new Dish {DishId=7, DishName="Компот33",Description="Быстро растворимый, 2 литра",Calories =180, GroupName="Напитки" },
                new Dish {DishId=8, DishName="Компот44",Description="Быстро растворимый, 2 литра",Calories =180, GroupName="Напитки" },
                new Dish {DishId=9, DishName="Компот55",Description="Быстро растворимый, 2 литра",Calories =180, GroupName="Напитки" }
                };
            context.Dishes.AddRange(dishes);
            context.SaveChanges();
        }
    }
}
