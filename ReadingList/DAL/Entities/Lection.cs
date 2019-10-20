using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Core.Entities
{
    //An obscure word meaning an act of reading.
    public class Lection
    {
        public int LectionId { get; set; }

        [Required]
        public int UserBookId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateStarted { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateFinished { get; set; }

        [Required]
        public string Format { get; set; }
        
        [Required]
        public string Language { get; set; }

        //Max is just a placeholder
        [Range(1, 10000)]
        public int? PageCount { get; set; }

        public Lection()
        {
            Language = "English";
        }

        [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5.")]
        [DisplayFormat(NullDisplayText = "Not rated")]
        public int? Rating { get; set; }

        public virtual UserBook UserBook { get; set; }
    }
}