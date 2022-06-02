using System.Collections.Generic;
using Мarketplace.Data.Models;

namespace Мarketplace.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Smartphone> favSmartphones { get; set; }
    }
}
