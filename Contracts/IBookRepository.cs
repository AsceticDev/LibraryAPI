using LibraryAPI.Entities.Models;

namespace LibraryAPI.Contracts
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks(bool trackChanges);
    }
}
