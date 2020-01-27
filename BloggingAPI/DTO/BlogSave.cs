using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingAPI.DTO
{
    public class BlogSave
    {
        public int userId { get; set; }
        public string blogContent { get; set; }
    }
}
