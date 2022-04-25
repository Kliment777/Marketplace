
namespace Мarketplace.Data.Models
{
    public class Smartphone //класс смартфон 
    {
        public int Id { get; set; }
        public string Designation { get; set; } //название смартфона
        public string ShortDescription { get; set; } //краткое описание смартфона
        public string LongDescription { get; set; } //полное описание
        public string Img { get; set; } //картинка
        public uint Price { get; set; } // цена
        public bool IsFavourite { get; set; } //популярный товар
        public bool Available { get; set; } // наличие
        public int CategoryId { get; set; }
        public virtual Сategory Category { get; set; }

    }
}
