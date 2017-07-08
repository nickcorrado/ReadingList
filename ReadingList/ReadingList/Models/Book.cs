using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadingList.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string PublicationType { get; set; }
        
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        public virtual ICollection<UserBook> UserBooks { get; set; }
    }
}