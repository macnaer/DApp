using IntroShop.Main.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main
{
    public class DBObjects
    {
        public static void Initial(DBContent content) 
        {
          
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }
            if (!content.Phone.Any())
            {
                content.AddRange(
                   new Phone
                   {
                      name = "Samsung S10",
                      description = "Best phone by Samsung Lorem ipsum dolor sin amet lorem ",
                      img = "/img/samsung_galaxy_s10_6_128_gb.jpg",
                      price = 23000,
                      Category = Categories["Flagman"]
                   },
                    new Phone
                    {
                        name = "Nokia 3310",
                        description = "Old phone. Lorem ipsum dolor sin amet lorem ",
                        img = "/img/nokia_3310.jpg",
                        price = 700,
                        Category = Categories["Flagman"]
                    },
                     new Phone
                     {
                         name = "Caterpiller 100500",
                         description = "Super phon with night vision. Lorem ipsum dolor sin amet lorem ",
                         img = "/img/cat_R10.jpg",
                         price = 700,
                         Category = Categories["Budget"]
                     }
                );
            }
            content.SaveChanges();
        }


        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Flagman", categoryDescription = "Phone with hight price and extra functions" },
                        new Category { categoryName = "Budget", categoryDescription = "Phone with low price without extra fubctions" }
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category item in list)
                    {
                        category.Add(item.categoryName, item);
                    }
                }
                return category;
            }

        }
    }
}
