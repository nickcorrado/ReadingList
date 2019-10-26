using Core.Entities.BookAggregate;
using System;
using System.Collections.Generic;

namespace Core.Entities
{
    public class UserBook
    {
        //I actually don't know how to write a
        //constructor for this. Do we pass in ids?
        //eShopOnWeb passes in ids, so we will, too

        //Not sure that passing the enum in is the right call
        public UserBook(int userId, int bookId, UserBookStatus status, int? priority, float? rating)
        {
            UserId = userId;
            BookId = bookId;
            Status = status;
            Priority = priority;
            Rating = rating;
            DateAdded = DateTime.Now;
        }
        public int UserBookId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public UserBookStatus Status { get; set; }

        //[Range(1, int.MaxValue)]
        public int? Priority { get; set; }
        //[DisplayFormat(NullDisplayText = "Not rated")]
        public float? Rating { get; set; }
        //[Required]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateAdded { get; private set; }
        public virtual User User { get; set; }
        public virtual Book Book { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Lection> Lections { get; set; }
    }
}
