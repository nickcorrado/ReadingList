using Core.Interfaces;
using System;
using System.Collections.Generic;

namespace Core.Entities.BookAggregate
{
    public class Book : IAggregateRoot
    {
        public Book(string title, string publicationType, List<BookAuthor> bookAuthors)
        {
            //I think exception-level validation should occur here, in the domain model
            //It's distinct from annotations-style validation on Web ViewModels
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Title cannot be null.", nameof(title));
            if (string.IsNullOrWhiteSpace(publicationType))
                throw new ArgumentException("Publication type cannot be null.", nameof(publicationType));

            if (title.Length > 120)
                throw new ArgumentException("Title cannot be greater than 120 characters.", nameof(title));

            if (bookAuthors.Count == 0)
                throw new ArgumentException("Book must have at least one author.", nameof(bookAuthors));

            Title = title;
            PublicationType = publicationType;
            _bookAuthors = bookAuthors;

            BookAuthors = new HashSet<BookAuthor>();
            UserBooks = new HashSet<UserBook>();
        }

        public int BookId { get; set; }

        //[Required]
        //[StringLength(120, ErrorMessage = "Book title cannot be longer than 120 characters.")]
        public string Title { get; set; }

        //[Required]
        public string PublicationType { get; set; }

        //per https://github.com/dotnet-architecture/eShopOnWeb/blob/master/src/ApplicationCore/Entities/OrderAggregate/Order.cs
        //I'm iffy about this. Basically, when a user creates a book, they should be able to select an existing Author (and choose
        //a role for them) or create a new Author (and choose a role for them). By passing BookAuthor objects, they can pass in a
        //role and an author id, but how does that handle a new author? Is that a question for my UserBookRepository?
        private readonly List<BookAuthor> _bookAuthors = new List<BookAuthor>();
        public IReadOnlyCollection<BookAuthor> Authors => _bookAuthors.AsReadOnly();

        //should I not be using these in my domain model?
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        public virtual ICollection<UserBook> UserBooks { get; set; }
    }
}