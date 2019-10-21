using System.Collections.Generic;

namespace Core.Entities
{
    public class Tag
    {
        public int TagId { get; set; }
        //[Required]
        //[StringLength(20, MinimumLength = 4, ErrorMessage = "Tag must be between 4 and 20 characters.")]
        public string TagName { get; set; }

        public virtual ICollection<UserBookTag> UserBookTags { get; set; }
    }
}