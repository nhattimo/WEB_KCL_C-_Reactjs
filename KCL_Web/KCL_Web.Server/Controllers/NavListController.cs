using KCL_Web.Server.Dtos.Navigation;
using KCL_Web.Server.Dtos.NavList;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace KCL_Web.Server.Controllers
{
    [ApiController]
    [Route("api/navlist")]
    public class NavListController : ControllerBase
    {
        private readonly INavListRepository _navListRepo;
        private readonly INavigationRepository _navigationRepo;

        public NavListController(INavListRepository navListRepo, INavigationRepository navigationRepo)
        {
            _navListRepo = navListRepo;
            _navigationRepo = navigationRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var navList = await _navListRepo.GetAllAsync();
            var navListDto = navList.Select(n => n.ToNavListDto());
            return Ok(navListDto);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var navList = await _navListRepo.GetByIdAsync(id);
            if (navList == null)
            {
                return null;
            }
            return Ok(navList.ToNavListDto());
        }

        [HttpPost("{navigationId:int}")]
        public async Task<IActionResult> Creater([FromRoute] int navigationId, [FromBody] CreateNavListDto navListDto)
        {
            if (!await _navigationRepo.NavigationExists(navigationId))
            {
                return BadRequest("Navigation dose not exist");
            }

            var navigationModel = navListDto.ToNavListFromCreateDto(navigationId);
            await _navListRepo.CreateAsync(navigationModel);
            return CreatedAtAction(nameof(GetById), new { id = navigationModel.NavId }, navigationModel.ToNavListDto());
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateNavListRequestDto updateNavList)
        {
            var navList = await _navListRepo.UpdateAsync(id, updateNavList.ToNavListFromUpdateDto(id));
            if (navList == null)
            {
                return null;
            }

            return Ok(navList.ToNavListDto());
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var navListModel = await _navListRepo.DeleteAsync(id);

            if (navListModel == null)
            {
                return NotFound("Comment dost not exist");
            }
            return Ok(navListModel.ToNavListDto());
        }
    }
}