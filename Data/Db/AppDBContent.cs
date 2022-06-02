using Microsoft.EntityFrameworkCore;
using Мarketplace.Data.Models;

namespace Мarketplace.Data.Db
{
    public class AppDBContent: DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) 
        { }
        public DbSet<Smartphone> Smarphone { get; set; }
        public DbSet<Сategory> Сategories { get; set; }

    }
}
