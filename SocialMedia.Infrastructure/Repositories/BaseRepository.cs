using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;

namespace SocialMedia.Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T Insert(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
