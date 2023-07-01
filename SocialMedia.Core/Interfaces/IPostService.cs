using SocialMedia.Core.Entities;

namespace SocialMedia.Core.Interfaces
{
    public interface IPostService
    {
        IEnumerable<Post> GetPosts();
        void InsertPost(Post post);
    }
}