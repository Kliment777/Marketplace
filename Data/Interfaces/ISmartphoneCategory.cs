

using System.Collections.Generic;
using Мarketplace.Data.Models;

namespace Мarketplace.Data.Interfaces
{
    public interface ISmartphoneCategory
    {
        IEnumerable<Сategory> AllCategories { get; }
    }
}
