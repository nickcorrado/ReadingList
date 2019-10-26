using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Configurations
{
    internal class AuthorConfiguration : EntityTypeConfiguration<Author>
    {
        internal AuthorConfiguration()
        {
            ToTable("Authors");

            HasKey(x => x.AuthorId)
                .Property(x => x.AuthorId)
                .HasColumnName("AuthorId")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.FirstName)
                .HasColumnName("FirstName")
                .HasColumnType("nvarchar")
                .HasMaxLength(35)
                .IsRequired();

            Property(x => x.LastName)
                .HasColumnName("LastName")
                .HasColumnType("nvarchar")
                .HasMaxLength(35)
                .IsRequired();

            Property(x => x.CreateDate)
                .HasColumnName("CreateDate")
                .HasColumnType("datetime2")
                .HasPrecision(7)
                .IsRequired();

            //like this?
            HasMany(x => x.BookAuthors)
                .WithRequired(x => x.Author)
                .HasForeignKey(x => x.AuthorId);
        }
    }
}
