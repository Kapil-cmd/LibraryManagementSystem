using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository.Entities;

namespace Repository.Configuration
{
    public class AuthorConfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(25).IsRequired();
            builder.Property(x => x.Address).IsRequired();

            builder.HasOne(x => x.Book)
                .WithMany(x => x.Author)
                .HasForeignKey(x => x.Name)
                .HasPrincipalKey(x => x.AuthorName)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
