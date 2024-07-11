using KCL_Web.Server.Dtos.Account;
using KCL_Web.Server.Interfaces;
using KCL_Web.Server.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NuGet.Protocol;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace KCL_Web.Server.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ITokenService _tokenService;
        private readonly SignInManager<AppUser> _signinManager;
        private readonly IConfiguration _configuration;
        private readonly IAccountRepository _Account;

        public AccountController(UserManager<AppUser>  userManager,IAccountRepository account, ITokenService tokenService, IConfiguration configuration, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _signinManager = signInManager;
            _Account = account;
            _configuration = configuration;
        }


        //[HttpPost("login")]
        //public async Task<IActionResult> Login(LoginDto loginDto)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    var user = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName == loginDto.Username.ToLower());

        //    if (user == null) return Unauthorized("Invalid username!");

        //    var result = await _signinManager.CheckPasswordSignInAsync(user, loginDto.Password, false);

        //    if (!result.Succeeded) return Unauthorized("Username not found and/or password incorrect");

        //    return Ok(
        //        new NewUserDto
        //        {
        //            UserName = user.UserName,
        //            Email = user.Email,
        //            Token = _tokenService.CreateToken(user)
        //        }
        //    );
        //}

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = _userManager.Users.ToList();

            var userList = users.Select(user => new
            {
                user.Id,
                user.UserName,
                user.Email
                
                // Các thông tin khác của người dùng cần thiết
            }).ToList();

            return Ok(userList);
        }


    

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = new AppUser { Name = registerDto.Username, Email = registerDto.Email };

            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (!result.Succeeded)
                return BadRequest(result.Errors);

            return Ok("User registered successfully.");
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Tìm người dùng bằng email
            var user = await _signinManager.UserManager.FindByEmailAsync(loginDto.Email);

            if (user == null)
            {
                return BadRequest("Invalid login attempt.");
            }

            // Sử dụng tên người dùng để đăng nhập
            var result = await _signinManager.PasswordSignInAsync(user.UserName, loginDto.Password, true, lockoutOnFailure: false);

            if (result.Succeeded)
            {

                var data = GenerateJwtToken(user);
                return Ok(new { Data = data });
            }
            else if (result.IsLockedOut)
            {
                return BadRequest("User account locked out.");
            }
            else
            {
                return BadRequest("Invalid login attempt.");
            }
        }

        [HttpDelete]
        [Route("Delete{userId}")]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            // Tìm người dùng bởi userId
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return NotFound();
            }

            // Xóa người dùng
            var result = await _userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                return Ok("Delete successfully");
            }

            // Trả về lỗi nếu không xóa được người dùng
            return BadRequest(result.Errors);
        }
        private ObjectResult GenerateJwtToken(AppUser user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            Console.WriteLine("jwt key", _configuration["Jwt:Key"]);
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
            new Claim(ClaimTypes.Name, user.UserName),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(JwtRegisteredClaimNames.Iat,((DateTimeOffset)DateTime.UtcNow).ToUnixTimeSeconds().ToString()),
                    // Thêm các thông tin khác từ user vào đây nếu cần thiết
                }),
                Expires = DateTime.UtcNow.AddHours(1), // Thời gian hết hạn của token
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var accessToken = tokenHandler.WriteToken(token);
            var response = new
            {
                status = true,
                user = new
                {
                    email = user.Email,
                    //role = user.IsAdmin ? 1 : 0
                },
                access_token = accessToken
            };
            return Ok(response);
        }
    }
}