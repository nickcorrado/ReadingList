using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //how do I set decimal precision?
            Property(x => x.Rating)
                .HasColumnName("Rating")
                .HasColumnType("decimal")
                .IsOptional();

            //relationships go here
        }
    }
}
