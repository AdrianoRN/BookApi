using BooksAPI.Repositories;

namespace BookApi.Controllers
{
    public class BooksController
    {
        private readonly IBookRepository _bookRepository;
        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
    }
}
