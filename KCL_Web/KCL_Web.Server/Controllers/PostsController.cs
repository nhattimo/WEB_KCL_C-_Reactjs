using AutoMapper;
using KCL_Web.Server.Dtos.Post;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Models;
using KCL_Web.Server.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace KCL_Web.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepostitory _postRepository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _environment;

        public PostsController(IPostRepostitory postRepository, IMapper mapper, IWebHostEnvironment environment)
        {
            _postRepository = postRepository;
            _mapper = mapper;
            _environment = environment;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var posts = await _postRepository.GetAllPostsAsync();

            var postsDto = _mapper.Map<List<PostDto>>(posts);
         
            return Ok(postsDto);
        }
        [HttpGet]
        [Route("{Id:int}")]
        public async Task<IActionResult> GetPostById([FromRoute] int Id)
        {
            var post = await _postRepository.GetPostByIdAsync(Id);
            if (post == null)
            {
                return NotFound();

            }
            var postDto = _mapper.Map<PostDto>(post);
            return Ok(postDto);
        }
        //[HttpPost]
        //public async Task<IActionResult> PostPosting([FromForm] AddingPost addingPost)
        //{
        //    var post= await _postRepository.CreatePostAsync(addingPost);
        //    var postDto = _mapper.Map<PostDto>(post);
        //    return CreatedAtAction("GetPostById", new { Id = post.PostId }, postDto);
        //}










        [HttpPut]
        [Route("{Id:int}")]
        public async Task<IActionResult> UpdatePostById([FromRoute] int Id, [FromBody] UpdatedPost updatedPost)
        {
            var post = await _postRepository.UpdatePostAsync(Id, updatedPost);
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
            var post= await _postRepository.DeletePostAsync(Id);
            if (post == null)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<PostDto>> CreatePost([FromForm] AddingPost addingPost)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (addingPost.Image != null)
            {
                addingPost.ImageUrl = await SaveImageAsync(addingPost.Image);
            }

            var post = await _postRepository.CreatePostAsync(addingPost);
            var postDto = _mapper.Map<PostDto>(post);
            return CreatedAtAction(nameof(GetPostById), new { id = post.PostId }, postDto);
        }

        private async Task<string> SaveImageAsync(IFormFile image)
        {
            var uploadsFolder = Path.Combine(_environment.WebRootPath, "dist", "img");
            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            var uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await image.CopyToAsync(fileStream);
            }

            return uniqueFileName;
        }
    }
}
