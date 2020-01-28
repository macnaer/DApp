using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShop.Main.Models
{
    public class Phone
    {
        public int id { set; get; }
        public string name { set; get; }
        public string description { set; get; }
        public string img { set; get; }
        public uint price { set; get; }
        public virtual Category Category { set; get; }
    }
}
