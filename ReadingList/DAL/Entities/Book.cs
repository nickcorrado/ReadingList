using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Entities
{
    public class Book
    {
        public int BookId { get; set; }

        //[Required]
        //[StringLength(120, ErrorMessage = "Book title cannot be longer than 120 characters.")]
        public string Title { get; set; }

        //[Required]
        public string PublicationType { get; set; }
        
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        public virtual ICollection<UserBook> UserBooks { get; set; }
    }
}