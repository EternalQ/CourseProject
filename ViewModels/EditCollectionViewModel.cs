using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.ViewModels
{
    public class EditCollectionViewModel
    {
        public string CollId { get; set; }
        public string CollectionName { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
        public IFormFile File { get; set; }

        public string ItemName { get; set; }
        public string Tags { get; set; }

        public string Num1_name { get; set; }
        public string Num2_name { get; set; }
        public string Num3_name { get; set; }
        public bool Num1_visibility { get; set; }
        public bool Num2_visibility { get; set; }
        public bool Num3_visibility { get; set; }
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }

        public string Str1_name { get; set; }
        public string Str2_name { get; set; }
        public string Str3_name { get; set; }
        public bool Str1_visibility { get; set; }
        public bool Str2_visibility { get; set; }
        public bool Str3_visibility { get; set; }
        public string Str1 { get; set; }
        public string Str2 { get; set; }
        public string Str3 { get; set; }

        public string Txt1_name { get; set; }
        public string Txt2_name { get; set; }
        public string Txt3_name { get; set; }
        public bool Txt1_visibility { get; set; }
        public bool Txt2_visibility { get; set; }
        public bool Txt3_visibility { get; set; }
        public string Txt1 { get; set; }
        public string Txt2 { get; set; }
        public string Txt3 { get; set; }

        public string Date1_name { get; set; }
        public string Date2_name { get; set; }
        public string Date3_name { get; set; }
        public bool Date1_visibility { get; set; }
        public bool Date2_visibility { get; set; }
        public bool Date3_visibility { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Date2 { get; set; }
        public DateTime Date3 { get; set; }

        public string Check1_name { get; set; }
        public string Check2_name { get; set; }
        public string Check3_name { get; set; }
        public bool Check1_visibility { get; set; }
        public bool Check2_visibility { get; set; }
        public bool Check3_visibility { get; set; }
        public bool Check1 { get; set; }
        public bool Check2 { get; set; }
        public bool Check3 { get; set; }
    }
}
