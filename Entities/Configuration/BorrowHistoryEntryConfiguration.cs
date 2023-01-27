using LibraryAPI.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAPI.Entities.Configuration
{
    public class BorrowHistoryEntryConfiguration : IEntityTypeConfiguration<BorrowHistoryEntry>
    {
        public void Configure(EntityTypeBuilder<BorrowHistoryEntry> builder)
        {
            builder.HasOne(x => x.User)
                .WithMany(x => x.BorrowHistoryEntries)
                .HasForeignKey(x => x.UserId);


            builder.HasOne(x => x.Book)
                .WithMany(x => x.BorrowHistoryEntries)
                .HasForeignKey(x => x.BookId);
        }
    }
}
