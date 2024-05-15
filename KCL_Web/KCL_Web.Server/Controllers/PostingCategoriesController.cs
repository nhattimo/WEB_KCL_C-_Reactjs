using AutoMapper;
using KCL_Web.Server.Dtos.PostCategory;
using KCL_Web.Server.Dtos.ProductCategory;
using KCL_Web.Server.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KCL_Web.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostingCategoriesController : ControllerBase
    {
        private readonly IPostingCategoryRepository _postingCategoryRepository;
        private readonly IMapper _mapper;
        public PostingCategoriesController(IPostingCategoryRepository postingCategoryRepository, IMapper mapper)
        {

            this._postingCategoryRepository = postingCategoryRepository;
            this._mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var postingCategories = await _postingCategoryRepository.GetAllPostingCategoriesAsync();

            var postingCategoriesDto = _mapper.Map<List<PostingCategoryDto>>(postingCategories);
            return Ok(postingCategories);
        }
        [HttpGet]
        [Route("{Id:int}")]
        public async Task<IActionResult> GetPostingCategoryById([FromRoute] int Id)
        {
            var postingCategory = await _postingCategoryRepository.GetPostingCategoryByIdAsync(Id);
            if (postingCategory == null)
            {
                return NotFound();
            }
            var postingCategoryDto = _mapper.Map<PostingCategoryDto>(postingCategory);
            return Ok(postingCategoryDto);
        }
        [HttpPost]
        public async Task<IActionResult> PostPostingCategory([FromBody] AddingPostCategory addingPostCategoryDto)
        {
            var postCategory = await _postingCategoryRepository.CreatePostingCategoryAsync(addingPostCategoryDto);
            var postCategoryDto = _mapper.Map<PostingCategoryDto>(postCategory);
            return CreatedAtAction("GetPostingCategoryById", new { Id = postCategoryDto.CategoryId }, postCategoryDto);
        }
        [HttpPut]
        [Route("{Id:int}")]
        public async Task<IActionResult> UpdatePostingCategoryById([FromRoute] int Id, [FromBody]UpdatedPostCategory updatedPostCategory)
        {
            var postCategory = await _postingCategoryRepository.UpdatePostingCategoryAsync(Id, updatedPostCategory);
            if (postCategory == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PostingCategoryDto>(postCategory));
        }
        [HttpDelete]
        [Route("{Id:int}")]
        public async Task<IActionResult> DeletePostCategory([FromRoute] int Id)
        {
            var postCatogory = await _postingCategoryRepository.DeletePostingCategoryAsync(Id);
            if (postCatogory == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
