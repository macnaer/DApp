using IntroShop.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.ViewModels
{
    public class PhoneListViewModel
    {
        public IEnumerable<Phone> allPhones { get; set; }
        public string currentCategory { get; set; }
    }
}
