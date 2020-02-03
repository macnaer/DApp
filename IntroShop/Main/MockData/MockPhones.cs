using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.MockData
{
    public class MockPhones : IAllPhones
    {
        private readonly IPhoneCategory _categoryPhone = new MockCategory();
        public IEnumerable<Phone> Phones
        {
            get
            {
                return new List<Phone>
                {
                    new Phone
                    {
                        name = "Samsung S10",
                        description = "Best phone by Samsung Lorem ipsum dolor sin amet lorem ",
                        img = "/img/samsung_galaxy_s10_6_128_gb.jpg",
                        price = 23000,
                        Category = _categoryPhone.AllCategories.First()
                    },
                    new Phone
                    {
                        name = "Nokia 3310",
                        description = "Old phone. Lorem ipsum dolor sin amet lorem ",
                        img = "/img/nokia_3310.jpg",
                        price = 700,
                        Category = _categoryPhone.AllCategories.Last()
                    }
                };
            }
        }
    }
}
