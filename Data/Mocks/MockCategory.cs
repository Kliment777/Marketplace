using System.Collections.Generic;
using Мarketplace.Data.Interfaces;
using Мarketplace.Data.Models;

namespace Мarketplace.Data.Mocks
{
    public class MockCategory : ISmartphoneCategory
    {
        public IEnumerable<Сategory> AllCategories 
        {
            get 
            {
                return new List<Сategory>
                {
                    new Сategory { CategoryName="Apple",Description="Apple-американская корпорация," +
                    " производитель персональных и планшетных компьютеров, аудиоплееров, смартфонов," +
                    " программного обеспечения." },
                    new Сategory { CategoryName="Samsung",Description="Samsung-южнокорейская группа " +
                    "компаний, один из крупнейших чеболей, основанный в 1938 году. На мировом рынке " +
                    "известен как производитель высокотехнологичных компонентов, включая полноцикловое" +
                    " производство интегральных микросхем, телекоммуникационного оборудования, бытовой" +
                    " техники, аудио- и видеоустройств." },
                    new Сategory { CategoryName="Huawei",Description="китайская компания, одна из " +
                    "крупнейших мировых компаний в сфере телекоммуникаций. Основана в 1987 году бывшим" +
                    " инженером Народно-освободительной армии Китая Жэнь Чжэнфэем." }
                };
            }
        } 
    }
}
