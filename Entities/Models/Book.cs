using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAPI.Entities.Models
{
    public class Book
    {
        [Column("BookId")]
        public Guid Id { get; set; }
        public string? Cover { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool? IsBorrowed { get; set; }
        public User? CurrentUserBorrowing { get; set; }
        public ICollection<BorrowHistoryEntry> BorrowHistoryEntries {get; set; }

    }
}
