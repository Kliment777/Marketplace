using System.Collections.Generic;
using Мarketplace.Data.Models;

namespace Мarketplace.Data.Interfaces
{
    public interface IAllSmartphones
    {
        IEnumerable<Smartphone> Smartphones { get; }
        IEnumerable<Smartphone> GetFavoritSmartphone { get; }
        Smartphone GetObjectSmartphone(int smartphoneId);
    }
}
