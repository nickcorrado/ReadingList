using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserBookService
    {

    }

    //I think I need these?
    public class UserBook
    {
        public int UserBookId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int? Priority { get; set; }
        public decimal? Rating { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
