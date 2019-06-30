using BlogPlatform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class TagPostsRepository : IRepository<TagPosts>
    {
        private BlogContext db;

        public TagPostsRepository(BlogContext db)
        {
            this.db = db;
        }

        public IEnumerable<TagPosts> GetAll()
        {
            return db.TagPostsdb.ToList();
        }

        public IEnumerable<TagPosts> GetByTagId(int ID)
        {
            return db.TagPostsdb.Where(c => c.TagId == ID);
        }

        public TagPosts GetById(int id)
        {
            return db.TagPostsdb.Single(c => c.PostId == id);
        }

        public void Delete(TagPosts obj)
        {
            throw new NotImplementedException();
        }
    }
}
