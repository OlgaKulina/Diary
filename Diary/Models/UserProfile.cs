using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Diary.Models
{
    public class UserProfile
    {

        public int Id { get; set; }
        public string Id_Login { get; set; }
        public string Id_Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

    }
}