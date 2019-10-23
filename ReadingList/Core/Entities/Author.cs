﻿using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class Author
    {
        public Author()
        {
            BookAuthors = new HashSet<BookAuthor>();
        }

        public int AuthorId { get; set; }

        //[Required]
        //[StringLength(35)]
        public string LastName { get; set; }

        //[Required]
        //[StringLength(35)]
        public string FirstName { get; set; }

        //[Required]
        public DateTime CreateDate { get; set; }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    }
}