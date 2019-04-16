using System;

namespace Diary.Models
{
    public class Note
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public  string Priority { get; set; }
        
        public DateTime Start_date { get; set; }

        public DateTime End_date { get; set; }

        public bool? Status { get; set; }

    }
}