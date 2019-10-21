using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Core.DTO
{
    public class LectionDTO
    {
        public int LectionId { get; set; }
        public int UserBookId { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime? DateFinished { get; set; }
        public string Format { get; set; }
        public string Language { get; set; }
        public int? PageCount { get; set; }
        public int? Rating { get; set; }
    }
}