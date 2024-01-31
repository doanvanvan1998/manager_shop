using ManagerShop.Model;
using Microsoft.EntityFrameworkCore;

namespace ManagerShop.data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }



    }
}
