using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
        public int UserBookId { get; set; }

        public int UserId { get; set; }

        public int BookId { get; set; }

        //[Required]
        //public Status Status { get; set; }

        //[Range(1, int.MaxValue)]
        public int? Priority { get; set; }

        //[DisplayFormat(NullDisplayText = "Not rated")]
        public float? Rating { get; set; }

        //[Required]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateAdded { get; set; }

        public virtual User User { get; set; }
        public virtual Book Book { get; set; }
        public virtual ICollection<UserBookTag> UserBookTags { get; set; }
        public virtual ICollection<Lection> Lections { get; set; }
    }
}
