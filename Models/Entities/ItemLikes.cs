using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models.Entities
{
    public class ItemLikes
    {
        public ItemLikes() { }
        public ItemLikes(IUser user, CustomItem item)
        {
            UserId = user.Id;
            ItemId = item.Id;
        }

        public string Id { get; set; }
        public string UserId { get; set; }
        public string ItemId { get; set; }
    }
}
