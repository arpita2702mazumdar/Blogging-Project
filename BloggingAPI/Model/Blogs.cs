using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingAPI.Model
{
    public class Blogmodel
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string blogContent { get; set; }
        public List<Comments> comments { get; set; }
    }
}
