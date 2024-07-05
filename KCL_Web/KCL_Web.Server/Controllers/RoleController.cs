using KCL_Web.Server.Dtos.Role;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace KCL_Web.Server.Controllers
{
    [ApiController]
    [Route("api/role")]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository _roleRepo;

        public RoleController(IRoleRepository roleRepo)
        {
            _roleRepo = roleRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var roles = await _roleRepo.GetAllAsync();
            var roleDto = roles.Select(r => r.ToRoleDto());
            return Ok(roleDto);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var role = await _roleRepo.GetByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            return Ok(role.ToRoleDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm]  CreateRoleRequestDto roleDto)
        {
            var roleModel = roleDto.ToRoleFromCreateDto();
            await _roleRepo.CreateAsync(roleModel);
            return CreatedAtAction(nameof(GetById), new { id = roleModel.RoleId }, roleModel.ToRoleDto());
        }
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateRoleRequestDto updateDto)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid id");
            }

            var roleModel = await _roleRepo.UpdateAsync(id, updateDto);

            if (roleModel == null)
            {
                return NotFound();
            }

            return Ok(roleModel.ToRoleDto());
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var roleModel = await _roleRepo.DeleteAsync(id);
            if (roleModel == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}