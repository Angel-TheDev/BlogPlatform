using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Model
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public virtual List<TagPosts> TagPosts { get; set; }


        public virtual Category category { get; set; }
        public int CategoryId { get; set; }
    }
}
