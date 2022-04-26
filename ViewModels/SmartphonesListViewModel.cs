using Мarketplace.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Мarketplace.ViewModels
{
    public class SmartphonesListViewModel
    {
        public IEnumerable<Smartphone> allSmartphones { get; set; }
        public string smartphonesCategory { get; set; }
    }
}
