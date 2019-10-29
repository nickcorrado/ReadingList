using Core.Entities.BookAggregate;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Configurations
{
    internal class BookConfiguration : EntityTypeConfiguration<Book>
    {
        internal BookConfiguration()
        {
            ToTable("Books");

            HasKey(x => x.BookId)
                .Property(x => x.BookId)
                .HasColumnName("BookId")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Title)
                .HasColumnName("Title")
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsRequired();

            //This will need to change; I'd like to
            //use an enum of publication types and store
            //them as a lookup table or something
            Property(x => x.PublicationType)
                .HasColumnName("PublicationType")
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsRequired();

            HasMany(x => x.BookAuthors)
                .WithRequired(x => x.Book)
                .HasForeignKey(x => x.BookId);
        }
    }
}
