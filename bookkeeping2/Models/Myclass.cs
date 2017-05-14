using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bookkeeping2.Models
{
    public class Myclass
    {
        //[Required]
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Money{ get; set; }
        public string Date { get; set; }
        public string Remarks { get; set; }
    }
}