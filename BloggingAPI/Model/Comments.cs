using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingAPI.Model
{
    public class Comments
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string commentContent { get; set; }
        public int blogId { get; set; }
        public Blogmodel blogs { get; set; }
    }
}
