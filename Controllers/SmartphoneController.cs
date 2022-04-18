using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Мarketplace.Data.Interfaces;

namespace Мarketplace.Controllers
{
    
    public class SmartphoneController : Controller
    {
        private readonly IAllSmartphones _allSmartphones;
        private readonly ISmartphoneCategory _smartphoneCategory;
        
        public SmartphoneController(IAllSmartphones allSmartphones,ISmartphoneCategory smartphoneCategory) 
        {
            _allSmartphones = allSmartphones;
            _smartphoneCategory = smartphoneCategory;
        }
        public ViewResult List()
        {
            var Smartphones = _allSmartphones.Smartphones;
            return View(Smartphones);
        }
    }
}
