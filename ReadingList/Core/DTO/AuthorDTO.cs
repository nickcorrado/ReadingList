using System;

namespace Core.DTO
{
    public class AuthorDTO
    {
        public int AuthorId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime CreateDate { get; set; }
    }
}