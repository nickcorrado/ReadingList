using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL
{
    //None of this is final code; just getting a sense of how a BLL works
    //DAL.Models.Author should maybe be in its own namespace without the
    //dbContext. Or replaced by a DTO as the return object. I'm not sure.
    class AuthorService
    {
        public IList<Author> GetAuthors()
        {
            var dbContext = new ApplicationDbContext();
            var authors = dbContext.Authors.ToList();
            return authors;
        }

        public Author GetAuthor(int id)
        {
            var dbContext = new ApplicationDbContext();
            var author = dbContext.Authors.Find(id);
            return author;
        }

        public void Insert(Author author)
        {
            var dbContext = new ApplicationDbContext();
            author.CreateDate = DateTime.Now;
            dbContext.Authors.Add(author);
        }

        public void Delete(int id)
        {
            var dbContext = new ApplicationDbContext();
            var author = dbContext.Authors.Find(id);
            if (author != null)
            {
                dbContext.Authors.Remove(author);
            }
        }
    }
}
