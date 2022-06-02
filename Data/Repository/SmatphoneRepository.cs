using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Мarketplace.Data.Db;
using Мarketplace.Data.Interfaces;
using Мarketplace.Data.Models;

namespace Мarketplace.Data.Repository
{
    public class SmatphoneRepository : IAllSmartphones
    {
        private readonly AppDBContent _appDBContent;
        public SmatphoneRepository(AppDBContent appDBContent) 
        {
            this._appDBContent = appDBContent;
        }
        public IEnumerable<Smartphone> Smartphones =>_appDBContent.Smarphone.Include(allSmartphones=>allSmartphones.Category);

        public IEnumerable<Smartphone> GetFavoritSmartphone => _appDBContent.Smarphone.Where(smart => smart.IsFavourite).Include(phones => phones.Category);


        public Smartphone GetObjectSmartphone(int smartphoneId) => _appDBContent.Smarphone.FirstOrDefault(obj => obj.Id == smartphoneId);
    }
}
