using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Мarketplace.Data.Interfaces;
using Мarketplace.ViewModels;

namespace Мarketplace.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllSmartphones _allSmartphones;
        public HomeController(IAllSmartphones AllSmartphones) 
        {
            _allSmartphones = AllSmartphones;
        }
        public ViewResult Index()
        {
            var homeSmartphone = new HomeViewModel
            {
                favSmartphones = _allSmartphones.GetFavoritSmartphone
            };
            return View(homeSmartphone);
        }
    }
}
