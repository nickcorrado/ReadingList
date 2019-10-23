using Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Configurations
{
    internal class UserBookConfiguration : EntityTypeConfiguration<UserBook>
    {
        internal UserBookConfiguration()
        {
            ToTable("UserBooks");

            HasKey(x => x.UserBookId)
                .Property(x => x.UserBookId)
                .HasColumnName("UserBookId")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.DateAdded)
                .HasColumnName("DateAdded")
                .HasColumnType("date")
                .IsRequired();

            Property(x => x.Priority)
                .HasColumnName("Priority")
                .HasColumnType("int")
                .IsOptional();

            Property(x => x.Rating)
                .HasColumnName("Rating")
                .HasColumnType("float")
                .IsOptional();

            //relationships go here
            HasMany(x => x.Tags)
                .WithMany(x => x.UserBooks)
                .Map(x =>
                {
                    x.ToTable("UserBookTags");
                    x.MapLeftKey("UserBookId");
                    x.MapRightKey("TagId");
                });
        }
    }
}
