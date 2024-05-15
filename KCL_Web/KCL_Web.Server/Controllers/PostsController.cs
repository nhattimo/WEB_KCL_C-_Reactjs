using AutoMapper;
using KCL_Web.Server.Dtos.Post;
using KCL_Web.Server.Dtos.ProductCategory;
using KCL_Web.Server.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KCL_Web.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepostitory _postRepostitory;
        private readonly IMapper _mapper;
        public PostsController(IPostRepostitory postRepostitory, IMapper mapper)
        {

            this._postRepostitory = postRepostitory;
            this._mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var posts = await _postRepostitory.GetAllPostsAsync();

            var postsDto = _mapper.Map<List<PostDto>>(posts);
            return Ok(postsDto);
        }
        [HttpGet]
        [Route("{Id:int}")]
        public async Task<IActionResult> GetPostById([FromRoute] int Id)
        {
            var post = await _postRepostitory.GetPostByIdAsync(Id);
            if (post == null)
            {
                return NotFound();
            }
            var postDto = _mapper.Map<PostDto>(post);
            return Ok(postDto);
        }
        [HttpPost]
        public async Task<IActionResult> PostPosting([FromBody] AddingPost addingPost)
        {
            var post= await _postRepostitory.CreatePostAsync(addingPost);
            var postDto = _mapper.Map<PostDto>(post);
            return CreatedAtAction("GetPostById", new { Id = post.PostId }, postDto);
        }
        [HttpPut]
        [Route("{Id:int}")]
        public async Task<IActionResult> UpdatePostById([FromRoute] int Id, [FromBody] UpdatedPost updatedPost)
        {
            var post = await _postRepostitory.UpdatePostAsync(Id, updatedPost);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PostDto>(post));
        }
        [HttpDelete]
        [Route("{Id:int}")]
        public async Task<IActionResult> DeletePost([FromRoute] int Id)
        {
            var post= await _postRepostitory.DeletePostAsync(Id);
            if (post == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
