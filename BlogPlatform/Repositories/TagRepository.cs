using BlogPlatform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class TagRepository : IRepository<Tag>
    {
        private BlogContext db;

        public TagRepository(BlogContext db)
        {
            this.db = db;
        }

        public void Create(Tag tag)
        {
            throw new NotImplementedException();
        }

        public void Delete(Tag obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Tag obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetAll()
        {
            throw new NotImplementedException();
        }

        public Tag GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetByTagId(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
