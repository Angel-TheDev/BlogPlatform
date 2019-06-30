using BlogPlatform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        private BlogContext db;

        public PostRepository(BlogContext db)
        {
            this.db = db;
        }

        public IEnumerable<Post> GetAll()
        {
            return db.Posts.ToList();
        }

        public Post GetById(int id)
        {
            return db.Posts.Single(c => c.Id == id);
        }

        public IEnumerable<Post> GetByTagId(int ID)
        {
            return db.Posts.Where(c => c.CategoryId == ID);

        }
        public void Delete(Post post)
        {
            db.Posts.Remove(post);
            db.SaveChanges();
        }
    }
    }
