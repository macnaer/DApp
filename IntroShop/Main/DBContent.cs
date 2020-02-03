using IntroShop.Main.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main
{
    public class DBContent : DbContext
    { 
        public DBContent(DbContextOptions<DBContent> options) : base(options)
        {

        }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
