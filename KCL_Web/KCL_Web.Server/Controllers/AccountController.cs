using KCL_Web.Server.Dtos.Account;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace KCL_Web.Server.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepo;
        private readonly IRoleRepository _roleRepo;

        public AccountController(IAccountRepository accountRepo, IRoleRepository roleRepo)
        {
            _accountRepo = accountRepo;
            _roleRepo = roleRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var accounts = await _accountRepo.GetAllAsync();
            var accountDtos = accounts.Select(a => a.ToAccountDto());
            return Ok(accountDtos);
        }

        [HttpGet("{email}")]
        public async Task<IActionResult> GetByEmail(string email)
        {
            var account = await _accountRepo.GetByEmailAsync(email);
            if (account == null)
            {
                return NotFound();
            }
            var accountDto = account.ToAccountDto();
            return Ok(accountDto);
        }

        [HttpPost("{roleId:int}")]
        public async Task<IActionResult> Register([FromRoute] int roleId, RegisterRequestDto registerDto)
        {
            if (!await _roleRepo.RoleExists(roleId))
            {
                return BadRequest("Role does not exist");
            }

            // Check if email is unique
            if (!await _accountRepo.IsEmailUniqueAsync(registerDto.Email))
            {
                return Conflict("Email already exists");
            }

            if (!await _accountRepo.IsValidEmail(registerDto.Email))
            {
                return Conflict("This email is already registered");
            }

            var accountModel = registerDto.ToAccountFromRegisterDto(roleId);

            await _accountRepo.CreateAsync(accountModel);
            return CreatedAtAction(nameof(GetByEmail), new { email = accountModel.Email }, accountModel.ToAccountDto());
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequestDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var isValidCredentials = await _accountRepo.ValidateCredentialsAsync(loginDto.Email, loginDto.Password);
            if (!isValidCredentials)
            {
                return Unauthorized("Invalid email or password");
            }

            // You may implement JWT token generation logic here for authentication
            // For demonstration purpose, let's return a simple message
            return Ok("Login successful");
        }

        [HttpPut("{email}")]
        public async Task<IActionResult> ResetPassword([FromRoute] string email, ResetPasswordRequestDto resetPasswordDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var isResetSuccessful = await _accountRepo.ResetPasswordAsync(email, resetPasswordDto.Password);
            if (!isResetSuccessful)
            {
                return NotFound("Email not found");
            }

            return Ok("Password reset successfully");
        }

        [HttpDelete("{email}")]
        public async Task<IActionResult> DeleteByEmail([FromRoute] string email)
        {
            var deletedAccount = await _accountRepo.DeleteByEmailAsync(email);
            if (deletedAccount == null)
            {
                return NotFound("Account not found");
            }
            return Ok("successfully");
        }


    }
}