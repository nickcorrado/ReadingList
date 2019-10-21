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

            //how do I set decimal precision of a nullable float?
            Property(x => x.Rating)
                .HasColumnName("Rating")
                .HasColumnType("float")
                .IsOptional();

            //relationships go here
            //I'm thinking that the UserBookTags definition is actually pointless
            //what we really want is just UserBooks and Tags and configure a many
            //to many relationship between the two, and EF will do the rest.
        }
    }
}
