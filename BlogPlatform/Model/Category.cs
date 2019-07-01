using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Model
{
    public class Category 
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public virtual List<Post> PostsList { get; set; }

        public Category()
        {

        }
    }
}
