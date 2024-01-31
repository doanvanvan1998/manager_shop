using ManagerShop.Model;
using ManagerShop.Repositories;
using static System.Reflection.Metadata.BlobBuilder;

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
            try
            {
                List<Book> books = repository.getAll();
                return books;
            }
            catch(Exception e)
            {
                return null;
            }
           
        }
    }

}
