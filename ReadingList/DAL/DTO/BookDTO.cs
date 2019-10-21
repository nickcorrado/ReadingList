using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Core.DTO
{
    public class BookDTO
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string PublicationType { get; set; }
    }
}