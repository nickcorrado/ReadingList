using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Core.Entities
{
    //public enum Role
    //{
    //    Author, Editor, Compiler, Translator
    //}

    public class BookAuthor
    {
        public int BookAuthorId { get; set; }
        //[Required]
        public int BookId { get; set; }
        //[Required]
        public int AuthorId { get; set; }
        //[Required]
        //public Role Role { get; set; }

        public virtual Book Book { get; set; }
        public virtual Author Author { get; set; }
    }
}