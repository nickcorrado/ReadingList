using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations
{
    internal class RoleConfiguration : EntityTypeConfiguration<Role>
    {
        internal RoleConfiguration()
        {
            ToTable("Roles");

            HasKey(x => x.RoleId)
                .Property(x => x.RoleId)
                .HasColumnName("RoleId")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(x => x.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(256)
                .IsRequired();

            HasMany(x => x.Users)
                .WithMany(x => x.Roles)
                .Map(x =>
                {
                    x.ToTable("UserRole");
                    x.MapLeftKey("RoleId");
                    x.MapRightKey("UserId");
                });
        }
    }
}
