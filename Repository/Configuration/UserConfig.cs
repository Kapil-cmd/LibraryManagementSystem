using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Entities;

namespace Repository.Configuration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserName).HasMaxLength(25).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(25).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(25).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(25).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.DateOfBirth).IsRequired();
            builder.Property(x => x.Password).IsRequired();
        }
    }
}
