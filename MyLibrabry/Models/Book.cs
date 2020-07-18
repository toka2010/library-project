using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyLibrabry.Models
{
    public class Book
    {
        public int b_id { get; set; }
        [DisplayName("Title")]
        public string b_title { get; set; }
        [DisplayName("Author")]
        public string b_author { get; set; }
        [DisplayName("publisher")]
        public string b_publisher { get; set; }
        [DisplayName("Publish date")]
        public int pdate { get; set; }
        public string category { get; set; }

        public int edition { get; set; }
        public int no_pages { get; set; }
       // public int avilable { get; set; }
        public int no_shelf { get; set; }
        public int no_copies { get; set; }
        public string photo { get; set; }
        public string b_description { get; set; }
        public string b_url { get; set; }
    }
}