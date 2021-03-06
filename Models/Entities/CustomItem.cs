using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models.Entities
{
    public class CustomItem
    {
        public CustomItem() 
        {
            AddingDate = DateTime.Now;
            Collection = new CustomCollection();
            Comments = new List<Comment>();
        }

        public CustomItem(string name, string tags)
        {
            Name = name;
            Tags = tags;
            AddingDate = DateTime.Now;
            Collection = new CustomCollection();
            Comments = new List<Comment>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Tags { get; set; }
        public int Likes { get; set; }
        public DateTime AddingDate { get; set; }

        public string CollectionId { get; set; }
        public CustomCollection Collection { get; set; }
        public List<Comment> Comments { get; set; }
        public string UserId { get => Collection.UserId; }

        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }

        public string Str1 { get; set; }
        public string Str2 { get; set; }
        public string Str3 { get; set; }

        public string Txt1 { get; set; }
        public string Txt2 { get; set; }
        public string Txt3 { get; set; }

        public DateTime Date1 { get; set; }
        public DateTime Date2 { get; set; }
        public DateTime Date3 { get; set; }

        public bool Check1 { get; set; }
        public bool Check2 { get; set; }
        public bool Check3 { get; set; }
    }
}
