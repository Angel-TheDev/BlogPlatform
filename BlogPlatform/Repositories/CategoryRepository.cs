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

        public void Delete(Category obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return db.Categories.Single(c => c.Id == id);
        }

        public IEnumerable<Category> GetByTagId(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
