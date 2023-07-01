using SocialMedia.Core.DTOs;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;

namespace SocialMedia.Core.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRository;
        public PostService(IPostRepository postRepository)
        {
            _postRository = postRepository;
        }

        public IEnumerable<Post> GetPosts()
        {
            return _postRository.GetPosts();
        }

        void IPostService.InsertPost(Post post)
        {
            _postRository.InsertPost(post);
        }
    }
}
