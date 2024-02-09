using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyTrip.Models.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }    
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Remark { get; set; }
        public Blog Blog { get; set; }
    }
}