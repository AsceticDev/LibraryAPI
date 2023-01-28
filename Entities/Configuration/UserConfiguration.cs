using LibraryAPI.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAPI.Entities.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            ////builder.HasMany(x => x.BorrowHistory)
            //    //.WithOne();
            //// Primary key
            //builder.HasKey(u => u.Id);

            //// Indexes for "normalized" username and email, to allow efficient lookups
            //builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            //builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

            //// Maps to the AspNetUsers table
            //builder.ToTable("LibraryUsers");

            //// Limit the size of columns to use efficient database types
            //builder.Property(u => u.UserName).HasMaxLength(256);
            //builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            //builder.Property(u => u.Email).HasMaxLength(256);
            //builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

            //builder.HasMany<BorrowHistoryEntry>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

        }
    }
}
