using System.Collections.Generic;
using Мarketplace.Data.Models;

namespace Мarketplace.Data.Interfaces
{
    public interface IAllSmartphones
    {
        IEnumerable<Smartphone> Electronics { get; }
        IEnumerable<Smartphone> GetFavoritSmartphone { get; set; }
        Smartphone GetObjectSmartphone(int smartphoneId);
    }
}
