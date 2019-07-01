using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogPlatform.Model;

namespace BlogPlatform.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> GetByTagId(int ID);
        void Delete(T obj);
        void Create(Post post);
        Post GetByLast();
        void Create(TagPosts tagpost);
        IEnumerable<Tag> GetAllTags();
    }
}
