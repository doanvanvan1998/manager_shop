using ManagerShop.Model;
using ManagerShop.Repositories;

namespace ManagerShop.Services
{
    public class BookService : IBookServices
    {
        private readonly IBookRepository repository;

        public BookService(IBookRepository repository)
        {
            this.repository = repository;
        }

        public List<Book> getAll()
        {
            List<Book> books = repository.getAll();
            return books;
        }
    }

}
