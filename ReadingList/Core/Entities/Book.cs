using System.Collections.Generic;

namespace Core.Entities
{
    public class Book
    {
        public Book(string title, string publicationType)
        {
            Title = title;
            PublicationType = publicationType;

            BookAuthors = new HashSet<BookAuthor>();
            UserBooks = new HashSet<UserBook>();
        }

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