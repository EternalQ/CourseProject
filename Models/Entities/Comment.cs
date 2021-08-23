using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models.Entities
{
    public class Comment
    {
        public Comment() { }
        public Comment(IUser user, string text)
        {
            User = user;
            Text = text;
        }

        public int Id { get; set; }
        public IUser User { get; set; }
        public string Text { get; set; }
    }
}
