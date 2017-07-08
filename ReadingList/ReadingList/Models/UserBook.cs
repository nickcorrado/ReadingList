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
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int Status { get; set; }
        public int? Priority { get; set; }
        public int? Rating { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateAdded { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Book Book { get; set; }
        public virtual ICollection<UserBookTag> UserBookTags { get; set; }
        public virtual ICollection<Lection> Lections { get; set; }
    }
}
