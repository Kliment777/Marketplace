using Мarketplace.Data.Interfaces;
using System.Collections.Generic;
using Мarketplace.Data.Models;
using Мarketplace.Data.Db;

namespace Мarketplace.Data.Repository
{
    public class CategoryRepository : ISmartphoneCategory
    {
        private readonly AppDBContent _appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this._appDBContent = appDBContent;
        }
        public IEnumerable<Сategory> AllCategories => _appDBContent.Сategories;
    }
}
