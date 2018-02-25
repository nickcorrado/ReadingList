using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReadingList.Models
{
    //A workaround to have Displayable enum values
    public enum Status
    {
        [Display(Name = "Unread")]
        Unread,
        [Display(Name = "Have read")]
        Read,
        [Display(Name = "Will reread")]
        WillReread
    }


    public class UserBook
    {
        public int UserBookId { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public Status Status { get; set; }

        [Range(1,int.MaxValue)]
        public int? Priority { get; set; }

        [DisplayFormat(NullDisplayText = "Not rated")]
        public float? Rating { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateAdded { get; set; }
        
        //A workaround for setting a default value, which
        //is not currently supported in EF6.
        public UserBook()
        {
            DateAdded = DateTime.Now;
        }

        public virtual ApplicationUser User { get; set; }
        public virtual Book Book { get; set; }
        public virtual ICollection<UserBookTag> UserBookTags { get; set; }
        public virtual ICollection<Lection> Lections { get; set; }
    }
}
