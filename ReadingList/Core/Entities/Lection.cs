using System;

namespace Core.Entities
{
    //An obscure word meaning an act of reading.
    //Might rename this UserBookHistory
    public class Lection
    {
        //we used to have a constructor defaulting this to English; may want to bring that back
        public Lection(DateTime dateStarted, DateTime? dateFinished, string language, string format, int? pagecount, int? rating)
        {
            DateStarted = dateStarted;
            DateFinished = dateFinished;
            Language = language;
            Format = format;
            PageCount = pagecount;
            Rating = rating;
        }

        public int LectionId { get; set; }
        //[Required]
        public int UserBookId { get; set; }
        //[Required]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateStarted { get; set; }
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateFinished { get; set; }
        //I wonder whether Format and Language could be lookup tables, too.
        //[Required]
        public string Format { get; set; }
        //[Required]
        public string Language { get; set; }
        //Max is just a placeholder
        //[Range(1, 10000)]
        public int? PageCount { get; set; }
        //[Range(0, 5, ErrorMessage = "Rating must be between 0 and 5.")]
        //[DisplayFormat(NullDisplayText = "Not rated")]
        public int? Rating { get; set; }
        public virtual UserBook UserBook { get; set; }
    }
}