using ManagerShop.data;
using ManagerShop.Model;

namespace ManagerShop.Repositories
{
    public class BookRepository : IBookRepository
    {
        private  MyContext _myContext;
        public BookRepository(MyContext myContext)
        {
            _myContext = myContext;
        }


        public List<Book> getAll()
        {
            List<Book> books = _myContext.Books.ToList();
            return books;
        }
    }
}
