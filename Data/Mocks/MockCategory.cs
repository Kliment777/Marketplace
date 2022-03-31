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
                    new Сategory { CategoryName="Смартфон",Description="Смартфон – это умный телефон, у которого есть открытая операционная система." },
                    new Сategory { CategoryName="Мобилный телефон",Description="Переносное средство связи,использует приёмопередатчик радиодиапазона и традиционную телефонную коммутацию для осуществления телефонной связи" },
                    new Сategory { CategoryName="Стационарный телефон",Description="Телефон, который использует для передачи сигналов, металлический провод или оптоволоконную телефонную линию." }
                };
            }
        } 
    }
}
