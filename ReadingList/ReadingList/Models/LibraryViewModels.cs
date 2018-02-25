using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadingList.Models
{
    //These might be pointless; man do I feel foolish now
    public class LibraryViewModel
    {
        //public IEnumerable<UserBook> UserBooks { get; set; }
        public int UserBookId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public Status Status { get; set; }
        public int? Priority { get; set; }
        public float? Rating { get; set; }
        public DateTime DateAdded { get; set; }
        public string Title { get; set; }
        public string PublicationType { get; set; }

        public ICollection<string> TagNames { get; set; }
        public ICollection<string> Authors { get; set; }
    }

    public class LibraryCreateViewModel
    {
        public int UserBookId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public Status Status { get; set; }
        public int? Priority { get; set; }
        public float? Rating { get; set; }
        public DateTime DateAdded { get; set; }
        public string Title { get; set; }
        public string PublicationType { get; set; }
    }

    public class LibraryEditViewModel
    {
        public int UserBookId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public Status Status { get; set; }
        public int? Priority { get; set; }
        public float? Rating { get; set; }
        public DateTime DateAdded { get; set; }
        public string Title { get; set; }
        public string PublicationType { get; set; }

        public ICollection<string> TagNames { get; set; }
        public ICollection<string> Authors { get; set; }
    }
}