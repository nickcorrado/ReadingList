namespace Core.Entities
{
    //public enum Role
    //{
    //    Author, Editor, Compiler, Translator
    //}

    public class BookAuthor
    {
        public BookAuthor(string role)
        {
            AuthorRole = role;
        }

        public int BookAuthorId { get; set; }
        //[Required]
        public int BookId { get; set; }
        //[Required]
        public int AuthorId { get; set; }
        //[Required]
        //public Role Role { get; set; }
        public string AuthorRole { get; set; }

        public virtual Book Book { get; set; }
        public virtual Author Author { get; set; }
    }
}