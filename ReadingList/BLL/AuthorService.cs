﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BLL
{
    //I'm switching things up to a persistence-ignorant approach,
    //so none of this works anymore as written
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
