using LibraryAPI.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryAPI.Entities.Configuration
{
    public class LoginModelConfiguration : IEntityTypeConfiguration<LoginModel>
    {
        public void Configure(EntityTypeBuilder<LoginModel> builder)
        {
            builder.HasData
            (
                new LoginModel
                {
                    Id = 1,
                    UserName = "asceticdev",
                    Password = "test123",
                }
             );
        }

    }
}
