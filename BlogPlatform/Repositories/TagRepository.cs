using BlogPlatform.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Repositories
{
    public class TagRepository : IRepository<Tag>
    {
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
