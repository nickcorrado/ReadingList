using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(35, ErrorMessage = "Last name cannot be longer than 35 characters.")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(35, ErrorMessage = "First name cannot be longer than 35 characters.")]
        public string FirstName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    }
}