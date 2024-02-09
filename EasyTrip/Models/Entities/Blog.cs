using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyTrip.Models.Entities
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}