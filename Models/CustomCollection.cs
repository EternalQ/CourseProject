using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<CustomCollection> CustomCollections { get; set; }
    }

    public class CustomCollection
    {

        public CustomCollection() { }
        public CustomCollection(string name, string descrip, string imageURL)
        {
            Name = name;
            Descrip = descrip;
            ImageURL = imageURL;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Descrip { get; set; }
        public string ImageURL { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public List<CustomItem> Items { get; set; }

        //terrible...
        public bool Num1_visibility { get; set; }
        public bool Num2_visibility { get; set; }
        public bool Num3_visibility { get; set; }

        public bool Str1_visibility { get; set; }
        public bool Str2_visibility { get; set; }
        public bool Str3_visibility { get; set; }

        public bool Txt1_visibility { get; set; }
        public bool Txt2_visibility { get; set; }
        public bool Txt3_visibility { get; set; }

        public bool Date1_visibility { get; set; }
        public bool Date2_visibility { get; set; }
        public bool Date3_visibility { get; set; }

        public bool Check1_visibility { get; set; }
        public bool Check2_visibility { get; set; }
        public bool Check3_visibility { get; set; }
    }
}
