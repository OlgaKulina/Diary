using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diary.Models
{
    public class Note
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public  string Priority { get; set; }

        DateTime Start_date { get; set; }

        DateTime End_date { get; set; }

        public bool? Status { get; set; }

    }
}