using KCL_Web.Server.Dtos.Navigation;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace KCL_Web.Server.Controllers
{
    [ApiController]
    [Route("api/navigation")]
    public class NavigationController : ControllerBase
    {
        private readonly INavigationRepository _navigationRepo;
        public NavigationController(INavigationRepository navigationRepo)
        {
            _navigationRepo = navigationRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var navigation = await _navigationRepo.GetAllAsync();
            var navigationDto = navigation.Select(x => x.ToNavigationDto());
            return Ok(navigationDto);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid id"); // Trả về lỗi nếu id không hợp lệ
            }
            var navigation = await _navigationRepo.GetByIdAsync(id);
            if (navigation == null)
            {
                return NotFound(); // Trả về 404 nếu không tìm thấy navigation
            }

            return Ok(navigation.ToNavigationDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateNavigationRequestDto navigationDto)
        {
            var navigationModel = navigationDto.ToStockFromNavigationDto();
            await _navigationRepo.CreateAsync(navigationModel);
            // Trả về thông báo tạo mới thành công và đường dẫn đến GetById để lấy thông tin chi tiết của mục điều hướng mới
            return CreatedAtAction(nameof(GetById), new { id = navigationModel.NavId }, navigationModel.ToNavigationDto());
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateNavigationRequestDto updateDto)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid id");
            }

            var navigationModel = await _navigationRepo.UpdateAsync(id, updateDto);

            if (navigationModel == null)
            {
                return NotFound();
            }

            return Ok(navigationModel.ToNavigationDto());

        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid id");
            }

            var navigationModel = await _navigationRepo.DeleteAsync(id);


            if (navigationModel == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}