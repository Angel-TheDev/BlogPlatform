using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Model
{
    public class TagPosts
    {
        public int Id { get; set; }
        public virtual int TagId { get; set; }
        public virtual Tag tag { get; set; }
        public virtual int PostId { get; set; }
        public virtual Post post { get; set; }
    }
}
