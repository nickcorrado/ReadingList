using System;
using System.Collections.Generic;

namespace Core.Entities.BookAggregate
{
    public class Author
    {
        public Author(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("First name cannot be null.", nameof(firstName));
            //last name can be null; suppose the author is Plato

            FirstName = firstName;
            LastName = lastName;
            CreateDate = DateTime.Now;

            BookAuthors = new HashSet<BookAuthor>();
        }

        public int AuthorId { get; set; }

        //[Required]
        //[StringLength(35)]
        public string LastName { get; set; }

        //[Required]
        //[StringLength(35)]
        public string FirstName { get; set; }

        //I'm not certain I want a create date. If I do, it might go on
        //every table.
        //[Required]
        public DateTime CreateDate { get; private set; }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    }
}