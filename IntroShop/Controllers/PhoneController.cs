using IntroShop.Main.Interfaces;
using IntroShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IntroShop.Controllers
{
    public class PhoneController : Controller
    {
        private readonly IAllPhones _allPhones;
        private readonly IPhoneCategory _allCategories;

        public PhoneController(IAllPhones iAllPhones, IPhoneCategory iPhoneCategory)
        {
            _allPhones = iAllPhones;
            _allCategories = iPhoneCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Phones";
            PhoneListViewModel obj = new PhoneListViewModel();
            obj.allPhones = _allPhones.Phones;
            obj.currentCategory = "Best category";

            return View(obj);
        }
    }
}
