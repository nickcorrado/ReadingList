using System;

namespace Core.DTO
{
    public class UserBookDTO
    {
        public int UserBookId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int? Priority { get; set; }
        public float? Rating { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
