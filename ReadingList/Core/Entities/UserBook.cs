using System;
using System.Collections.Generic;

namespace Core.Entities
{
    ////A workaround to have Displayable enum values
    //public enum Status
    //{
    //    [Display(Name = "Unread")]
    //    Unread,
    //    [Display(Name = "Have read")]
    //    Read,
    //    [Display(Name = "Will reread")]
    //    WillReread
    //}

    public class UserBook
    {
        //I actually don't know how to write a
        //constructor for this. Do we pass in ids? 
        //DateAdded, at least, needs privately set
        //eShopOnWeb passes in ids, so we will, too

        //I really feel, though, like we need an
        //aggregate for user books, so that the
        //list of authors, status, priority, rating,
        //etc. can all be added at once
        public UserBook(int userId, int bookId, string status, int? priority, float? rating)
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
        //Would like to turn this into a lookup table
        //[Required]
        //public Status Status { get; set; }
        public string Status { get; set; }

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
