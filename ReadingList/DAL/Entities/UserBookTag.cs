using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Entities
{
    public class UserBookTag
    {
        public int UserBookTagId { get; set; }
        [Required]
        public int UserBookId { get; set; }
        [Required]
        public int TagId { get; set; }

        public virtual UserBook UserBook { get; set; }
        public virtual Tag Tag { get; set; }
    }
}