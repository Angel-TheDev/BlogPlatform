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

        public Post GetById(int id)
        {
            return db.Posts.Single(c => c.PostId == id);
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

        public void Create(Post post)
        {
            db.Posts.Add(post);
            db.SaveChanges();
        }

        public Post GetByLast()
        {
            throw new NotImplementedException();
        }

        public void Create(TagPosts tagpost)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAllTags()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            return db.Posts.ToList();
        }

        IEnumerable<Tag> IRepository<Post>.GetAllTags()
        {
            throw new NotImplementedException();
        }

        public void Edit(Post post)
        {
            db.Posts.Update(post);
            db.SaveChanges();
        }
    }
    }
    