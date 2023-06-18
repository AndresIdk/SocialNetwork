using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;

namespace SocialMedia.Infrastructure.Repositories
{
    public class MongoRepository : IPostRepository
    {
        List<Post> posts = new()
        {
            new Post { Date= DateTime.Now, Description="hola", Image="aaa", PostId=1, UserId=2 }
        };
        public IEnumerable<Post> GetPosts()
        {
            return this.posts;
        }

        public void InsertPost(Post post)
        {
            this.posts.Add(post);
        }
    }
}
