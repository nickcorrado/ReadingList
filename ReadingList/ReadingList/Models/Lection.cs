using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReadingList.Models
{
    //An obscure word meaning an act of reading.
    public class Lection
    {
        public int LectionId { get; set; }
        public int UserBookId { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateStarted { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateFinished { get; set; }
        public string Format { get; set; }
        public string Language { get; set; }
        public int Rating { get; set; }

        public virtual UserBook UserBook { get; set; }
    }
}