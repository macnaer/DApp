using IntroShop.Main.Interfaces;
using IntroShop.Main.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Repository
{
    public class PhoneRepository : IAllPhones
    {
        private readonly DBContent dbContent;
        public PhoneRepository (DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<Phone> Phones => dbContent.Phone.Include(c => c.Category);
    }
}
