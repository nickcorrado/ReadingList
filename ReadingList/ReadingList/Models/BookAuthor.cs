using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadingList.Models
{
    public enum Role
    {
        Author, Editor, Compiler, Translator
    }

    public class BookAuthor
    {
        public int BookAuthorId { get; set; }
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        public Role Role { get; set; }

        public virtual Book Book { get; set; }
        public virtual Author Author { get; set; }
    }
}