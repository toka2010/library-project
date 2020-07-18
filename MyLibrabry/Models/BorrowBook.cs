using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyLibrabry.Models
{
    public class BorrowBook
    {
        public int bo_id { get; set; }
        public int bo_day { get; set; }
        public int bo_month { get; set; }
        public int bo_year { get; set; }
        public string arr_date { get; set; }
        public int is_available { get; set; }
        public int userid { get; set; }
        public int book_id { get; set; }
        public string u_mem { get; set; }
    }
}