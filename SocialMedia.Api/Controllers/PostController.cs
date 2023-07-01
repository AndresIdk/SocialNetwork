using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Api.Responses;
using SocialMedia.Core.DTOs;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;

namespace SocialMedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;
        public PostController(IPostService postService, IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PostDto>> GetPosts()
        {
            var posts = _postService.GetPosts();
            var postsDto = _mapper.Map<IEnumerable<PostDto>>(posts);
            var response = new ApiResponse<IEnumerable<PostDto>>(postsDto);
            return Ok(response);
        }

        [HttpPost]
        public ActionResult<PostDto> InsertPost([FromBody] PostDto postDto)
        {
            var post = _mapper.Map<Post>(postDto);
            _postService.InsertPost(post);
            var postDtoR = _mapper.Map<PostDto>(post);
            var response = new ApiResponse<PostDto>(postDtoR);
            return Ok(response);
        }

        [HttpGet("{cad:int}")]
        public int Mensaje(int num) 
        {
            return num;
        }

    }
}
