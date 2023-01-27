using LibraryAPI.Contracts;
using LibraryAPI.Entities.Models;

namespace LibraryAPI.Repository
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Book> GetAllBooks(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(x => x.Title)
            .ToList();
    }
}
