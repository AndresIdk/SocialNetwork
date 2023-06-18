using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Core.DTOs;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;

namespace SocialMedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;
        public PostController(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PostDto>> GetPosts()
        {
            var posts = _postRepository.GetPosts();
            var postsDto = _mapper.Map<IEnumerable<PostDto>>(posts);
            System.Diagnostics.Debug.WriteLine("hola");
            return Ok(postsDto);
        }

        [HttpPost]
        public ActionResult<Post> InsertPost([FromBody] PostDto postDto)
        {
            var post = _mapper.Map<Post>(postDto);
            _postRepository.InsertPost(post);

            return Ok(post);
        }

        [HttpGet("{cad:int}")]
        public int Mensaje(int num) 
        {
            return num;
        }

    }
}
