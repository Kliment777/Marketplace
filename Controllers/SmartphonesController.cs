using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Мarketplace.Data.Interfaces;

namespace Мarketplace.Controllers
{
    
    public class SmartphonesController : Controller
    {
        private readonly IAllSmartphones _allSmartphones;
        private readonly ISmartphoneCategory _smartphoneCategory;
        
        public SmartphonesController(IAllSmartphones allSmartphones,ISmartphoneCategory smartphoneCategory) 
        {
            _allSmartphones = allSmartphones;
            _smartphoneCategory = smartphoneCategory;
        }
        public ViewResult List()
        {
            var smartphones = _allSmartphones.Smartphones;
            return View(smartphones);
        }
    }
}
