using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadingList.Models
{
    public class Lection
    {
        public int LectionId { get; set; }
        public int UserBookId { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateFinished { get; set; }
        public string Format { get; set; }
        public string Language { get; set; }
        public int Rating { get; set; }

        public virtual UserBook UserBook { get; set; }
    }
}