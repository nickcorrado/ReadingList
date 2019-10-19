using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class Author
    {
        public Author()
        {
            BookAuthors = new HashSet<BookAuthor>();
        }

        public int AuthorId { get; set; }

        //[Required]
        //[Display(Name = "Last Name")]
        //[StringLength(35, ErrorMessage = "Last name cannot be longer than 35 characters.")]
        [Required]
        [StringLength(35)]
        public string LastName { get; set; }

        //[Required]
        //[Display(Name = "First Name")]
        //[StringLength(35, ErrorMessage = "First name cannot be longer than 35 characters.")]
        [Required]
        [StringLength(35)]
        public string FirstName { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        //[Display(Name = "Full Name")]
        //public string FullName
        //{
        //    get
        //    {
        //        return FirstName + " " + LastName;
        //    }
        //}

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    }
}