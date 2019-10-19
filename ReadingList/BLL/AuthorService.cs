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
            using (var dbContext = new ApplicationDbContext())
            {
                var authors = dbContext.Authors.ToList();
                return authors;
            }
        }

        public Author GetAuthor(int id)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var author = dbContext.Authors.Find(id);
                return author;
            }
        }

        public int Insert(Author author)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                author.CreateDate = DateTime.Now;
                dbContext.Authors.Add(author);
                return dbContext.SaveChanges();
            }
        }

        public int Delete(int id)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var author = dbContext.Authors.Find(id);
                if (author != null)
                {
                    dbContext.Authors.Remove(author);
                    return dbContext.SaveChanges();
                }
            }
            //no such record
            return 0;
        }
    }
}
