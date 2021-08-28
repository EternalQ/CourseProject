using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models.Entities
{
    public class Comment
    {
        public Comment() { }
        public Comment(string text)
        {
            Text = text;
            AddingDate = DateTime.Now;
        }

        public string Id { get; set; }
        public string Text { get; set; }
        public DateTime AddingDate { get; set; }

        public string UserId { get; set; }
        public IUser User { get; set; }
    }
}
