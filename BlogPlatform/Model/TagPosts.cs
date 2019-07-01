using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Model
{
    public class TagPosts
    {
        public int TagPostsId { get; set; }
        public virtual Tag tag { get; set; }
        public int TagId { get; set; }
        public virtual Post post { get; set; }
        public int PostId { get; set; }
    }
}
