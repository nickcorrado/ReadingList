using Core.Entities;
using Data.Configurations;
using System.Data.Entity;

namespace Data
{
    internal class ApplicationDbContext : DbContext
    {
        internal ApplicationDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        //why no Claims?
        internal IDbSet<User> Users { get; set; }
        internal IDbSet<Role> Roles { get; set; }
        internal IDbSet<ExternalLogin> ExternalLogins { get; set; }

        internal IDbSet<Author> Authors { get; set; }
        internal IDbSet<Tag> Tags { get; set; }
        internal IDbSet<Book> Books { get; set; }
        internal IDbSet<UserBook> UserBooks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
            modelBuilder.Configurations.Add(new ExternalLoginConfiguration());
            modelBuilder.Configurations.Add(new ClaimConfiguration());

            modelBuilder.Configurations.Add(new AuthorConfiguration());
            modelBuilder.Configurations.Add(new TagConfiguration());
            modelBuilder.Configurations.Add(new UserBookConfiguration());
        }
    }
}
