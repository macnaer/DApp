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
                        description = "Best phone by Samsung",
                        img = "https://i1.rozetka.ua/goods/11052575/samsung_galaxy_s10_6_128_gb_white_sm_g973fzwdsek_images_11052575871.jpg",
                        price = 23000,
                        Category = _categoryPhone.AllCategories.First()
                    },
                    new Phone
                    {
                        name = "Nokia 3310",
                        description = "Old phone.",
                        img = "https://static.turbosquid.com/Preview/001329/666/6L/_DHQ.jpg",
                        price = 700,
                        Category = _categoryPhone.AllCategories.Last()
                    }
                };
            }
        }
    }
}
