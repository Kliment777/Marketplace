using System.Collections.Generic;

namespace Мarketplace.Data.Models 
{
    public class Сategory 
    {
        public int id { get; set; } 
        public string categoryName { get; set; } // название категории 
        public string description { get; set; } // описание

        public List<Smartphone> Electronics { get; set; } //электроника
    }
}
