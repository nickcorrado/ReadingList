using Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Configurations
{
    internal class TagConfiguration : EntityTypeConfiguration<Tag>
    {
        internal TagConfiguration()
        {
            ToTable("Tags");

            HasKey(x => x.TagId)
                .Property(x => x.TagId)
                .HasColumnName("TagId")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.TagName)
                .HasColumnName("TagName")
                .HasColumnType("nvarchar")
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}
