using SocialMedia.Core.Entities;

namespace SocialMedia.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
            public IEnumerable<T> GetAll();
            public T Insert(T entity);
    }
}
