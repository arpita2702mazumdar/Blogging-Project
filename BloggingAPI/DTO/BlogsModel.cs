using BloggingAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingAPI.DTO
{
    public class BlogsModel
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string blogContent { get; set; }
        public List<Comments> comments { get; set; }
    }
}
