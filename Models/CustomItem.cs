using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
    }

    public class CustomItem
    {
        public CustomItem() { }
        public CustomItem(int id, string name, string tags)
        {
            Id = id;
            Name = name;
            Tags = tags;
            Comments = new List<Comment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Tags { get; set; }

        public int CollectionId { get; set; }
        public CustomCollection Collection { get; set; }

        public List<Comment> Comments { get; set; }

        public string Num1_name { get; set; }
        public string Num2_name { get; set; }
        public string Num3_name { get; set; }
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }

        public string Str1_name { get; set; }
        public string Str2_name { get; set; }
        public string Str3_name { get; set; }
        public string Str1 { get; set; }
        public string Str2 { get; set; }
        public string Str3 { get; set; }

        public string Txt1_name { get; set; }
        public string Txt2_name { get; set; }
        public string Txt3_name { get; set; }
        public string Txt1 { get; set; }
        public string Txt2 { get; set; }
        public string Txt3 { get; set; }

        public string Date1_name { get; set; }
        public string Date2_name { get; set; }
        public string Date3_name { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Date2 { get; set; }
        public DateTime Date3 { get; set; }

        public string Check1_name { get; set; }
        public string Check2_name { get; set; }
        public string Check3_name { get; set; }
        public bool Check1 { get; set; }
        public bool Check2 { get; set; }
        public bool Check3 { get; set; }
    }
}
