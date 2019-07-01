using BlogPlatform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private BlogContext db;

        public CategoryRepository(BlogContext db)
        {
            this.db = db;
        }

        public void Create(Post post)
        {
            throw new NotImplementedException();
        }

        public void Create(TagPosts tagpost)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public IEnumerable<Tag> GetAllTags()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            return db.Categories.Single(c => c.Id == id);
        }

        public Post GetByLast()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetByTagId(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
