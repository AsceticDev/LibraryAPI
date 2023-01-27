using LibraryAPI.Entities.Configuration;
using LibraryAPI.Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Repository
{
    public class RepositoryContext : IdentityDbContext<User>
    {
        public RepositoryContext(DbContextOptions options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            //modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            new BorrowHistoryEntryConfiguration().Configure(modelBuilder.Entity<BorrowHistoryEntry>());
            new BookConfiguration().Configure(modelBuilder.Entity<Book>());
            new UserConfiguration().Configure(modelBuilder.Entity<User>());

            //modelBuilder.Entity<Book>()
            //    .HasMany(s => s.BorrowHistoryEntries)
            //    .WithOne();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Company>? Companies { get; set; }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Book>? Books { get; set; }
        public override DbSet<User>? Users { get; set; }
        public DbSet<BorrowHistoryEntry>? BorrowHistoryEntries{ get; set; }
    }
}
