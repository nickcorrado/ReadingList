using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Core.DTO
{
    public class TagDTO
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
    }
}