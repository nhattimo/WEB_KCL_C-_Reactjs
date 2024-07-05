using KCL_Web.Server.Dtos.Banner;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace KCL_Web.Server.Controllers
{
    [ApiController]
    [Route("api/banner")]
    public class BannerController : ControllerBase
    {
        private readonly IBannerRepository _bannerRepo;

        public BannerController(IBannerRepository bannerRepo)
        {
            _bannerRepo = bannerRepo;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var banner = await _bannerRepo.GetAllAsync();
            var BannerDto = banner.Select(b => b.ToBannerDto());
            return Ok(BannerDto);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById( int id)
        {
            var bannerModel = await _bannerRepo.GetByIdAsync(id);
            if (bannerModel == null)
            {
                return NotFound();
            }
            return Ok(bannerModel.ToBannerDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBannerRequestDto BannerDto)
        {
            var bannerModel = BannerDto.ToBannerFromCreateDto();
            await _bannerRepo.CreateAsync(bannerModel);
            return CreatedAtAction(nameof(GetById), new { id = bannerModel.BannerId }, bannerModel.ToBannerDto());
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateBannerRequestDto updateDto)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid id");
            }

            var BannerModel = await _bannerRepo.UpdateAsync(id, updateDto);

            if (BannerModel == null)
            {
                return NotFound();
            }
            return Ok(BannerModel.ToBannerDto());
        }


        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var BannerModel = await _bannerRepo.DeleteAsync(id);
            if (BannerModel == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}