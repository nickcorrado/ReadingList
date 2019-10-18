using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL
{
    //None of this is final code; just getting a sense of how a BLL works
    class AuthorService
    {
        public IList<Author> GetAuthors()
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
            var authors = dbContext.Authors.ToList();
            return authors;
        }

        public void Insert(Author author)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
            author.CreateDate = DateTime.Now;
            dbContext.Authors.Add(author);
        }
    }
}
