using BlogPlatform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class TagPostsRepository  IRepository<TagPosts>
    {
        private BlogContext db;

        public TagPostsRepository(BlogContext db)
        {
            this.db = db;
        }

        public IEnumerable<TagPosts> GetAll()
        {
        throw new NotImplementedException();
        }

        //public IEnumerable<TagPosts> GetById(int Id)
        //{
        //    return db.TagPostsdb.Where(c => c.TagId == Id);
        //}

        public TagPosts GetById(int id)
        {
            return db.TagPostsdb.Single(c => c.PostId == id);
        }

        public void Delete(TagPosts obj)
        {
            throw new NotImplementedException();
        }


        public void Create(TagPosts tagPosts)
        {
            db.TagPosts.Add(tagPosts);
            db.SaveChanges();
        }

        public void Edit(TagPosts obj)
        {
            throw new NotImplementedException();
        }
    }
}