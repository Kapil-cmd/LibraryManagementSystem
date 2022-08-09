using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Entities;

namespace Repository.Configuration
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(25).IsRequired();
            builder.Property(x => x.UploadedBy).HasMaxLength(25).IsRequired();

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.CategoryName)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.User)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.UploadedBy)
                .HasPrincipalKey(x => x.UserName)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Author)
                .WithMany(x => x.Books)
                .
        }
    }
}
