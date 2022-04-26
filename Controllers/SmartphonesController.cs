using Microsoft.AspNetCore.Mvc;
using Мarketplace.ViewModels;
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
            SmartphonesListViewModel obj = new SmartphonesListViewModel();
            obj.allSmartphones = _allSmartphones.Smartphones;
            obj.smartphonesCategory = "Категории";
            return View(obj);
        }
    }
}
