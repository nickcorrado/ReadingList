using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadingList.Models
{
    public class LibraryViewModel
    {
        public IEnumerable<UserBook> UserBooks { get; set; }
    }
}