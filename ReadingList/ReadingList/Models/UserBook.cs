using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReadingList.Models
{
    public class UserBook
    {
        public int UserBookId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public int Status { get; set; }

        public int? Priority { get; set; }

        [DisplayFormat(NullDisplayText = "Not rated")]
        public int? Rating { get; set; }
        
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
