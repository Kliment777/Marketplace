using System.Collections.Generic;
using System.Linq;
using Мarketplace.Data.Interfaces;
using Мarketplace.Data.Models;

namespace Мarketplace.Data.Mocks
{
    public class MockSmartphone : IAllSmartphones
    {
        private readonly ISmartphoneCategory smartphoneCategory = new MockCategory();
        public IEnumerable<Smartphone> Electronics
        {
            get
            {
                return new List<Smartphone>
                {
                    new Smartphone
                    {
                        Designation ="iPhone 11 64GB",
                        ShortDescription="",
                        LongDescription="",
                        Img="",
                        Price=54000,
                        IsFavourite=true,
                        Available=true,
                        Category= smartphoneCategory.AllCategories.First()

                        
                    }
                };
            }
        }
        
        public IEnumerable<Smartphone> GetFavoritSmartphone 
        {   
            get => throw new System.NotImplementedException(); 
            set => throw new System.NotImplementedException(); 
        }

        public Smartphone GetObjectSmartphone(int smartphoneId)
        {
            throw new System.NotImplementedException();
        }
    }
}
