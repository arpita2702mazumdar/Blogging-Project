using BloggingAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingAPI.DTO
{
    public class CommentsModel
    {
        public int userId { get; set; }
        public string commentContent { get; set; }
        public int blogId { get; set; }
    }
}
