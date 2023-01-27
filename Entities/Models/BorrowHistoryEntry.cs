using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAPI.Entities.Models
{
    public class BorrowHistoryEntry
    {
        [Column("BorrowHistoryEntryId")]
        public Guid Id { get; set; }
        public DateTime entryTime { get; set; }
        public bool? isReturned { get; set; }
        public bool? isBorrowed { get; set; }
        public Guid UserId { get; set; }
        //[ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public Guid BookId { get; set; }
        //[ForeignKey(nameof(BookId))]
        public Book Book { get; set; }
    }
}
