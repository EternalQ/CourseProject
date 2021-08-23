using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models.Entities
{
    public class Subject
    {
        public Subject()
        {
            CustomCollections = new List<CustomCollection>();
        }

        public Subject(string name)
        {
            Name = name;
            CustomCollections = new List<CustomCollection>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public List<CustomCollection> CustomCollections { get; set; }
    }
}
