using System.Collections.Generic;

namespace Мarketplace.Data.Models 
{
    public class Сategory 
    {
        public int Id { get; set; } 
        public string CategoryName { get; set; } // название категории 
        public string Description { get; set; } // описание

        public List<Smartphone> Electronics { get; set; } //электроника
    }
}
