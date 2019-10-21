using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Core.DTO
{
    public class UserBookTagDTO
    {
        public int UserBookTagId { get; set; }
        public int UserBookId { get; set; }
        public int TagId { get; set; }

        public virtual UserBook UserBook { get; set; }
        public virtual Tag Tag { get; set; }
    }
}