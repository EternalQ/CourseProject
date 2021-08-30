using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models.Entities
{
    public class CustomCollection
    {

        public CustomCollection() 
        { 
            Subject = new Subject();
            Items = new List<CustomItem>();
        }

        public CustomCollection(string name, string descrip, string imageURL)
        {
            Name = name;
            Descrip = descrip;
            ImageURL = imageURL;
            Subject = new Subject();
            Items = new List<CustomItem>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Descrip { get; set; }
        public string ImageURL { get; set; }
        public string ImagePublicId { get; set; }

        public string SubjectId { get; set; }
        public Subject Subject { get; set; }
        public string UserId { get; set; }
        public IUser User { get; set; }
        public List<CustomItem> Items { get; set; }

        //terrible...
        public bool Num1_visibility { get; set; }
        public string Num1_name { get; set; }
        public bool Num2_visibility { get; set; }
        public string Num2_name { get; set; }
        public bool Num3_visibility { get; set; }
        public string Num3_name { get; set; }

        public bool Str1_visibility { get; set; }
        public string Str1_name { get; set; }
        public bool Str2_visibility { get; set; }
        public string Str2_name { get; set; }
        public bool Str3_visibility { get; set; }
        public string Str3_name { get; set; }

        public bool Txt1_visibility { get; set; }
        public string Txt1_name { get; set; }
        public bool Txt2_visibility { get; set; }
        public string Txt2_name { get; set; }
        public bool Txt3_visibility { get; set; }
        public string Txt3_name { get; set; }

        public bool Date1_visibility { get; set; }
        public string Date1_name { get; set; }
        public bool Date2_visibility { get; set; }
        public string Date2_name { get; set; }
        public bool Date3_visibility { get; set; }
        public string Date3_name { get; set; }

        public bool Check1_visibility { get; set; }
        public string Check1_name { get; set; }
        public bool Check2_visibility { get; set; }
        public string Check2_name { get; set; }
        public bool Check3_visibility { get; set; }
        public string Check3_name { get; set; }
    }
}
