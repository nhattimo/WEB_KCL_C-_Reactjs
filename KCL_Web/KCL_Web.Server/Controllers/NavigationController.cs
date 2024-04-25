using KCL_Web.Server.Dtos.Navigation;
using KCL_Web.Server.Mappers;
using KCL_Web.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace KCL_Web.Server.Controllers
{
    /// <summary>
    /// Controller xử lý các yêu cầu liên quan đến các mục điều hướng trong hệ thống.
    /// </summary>
    [ApiController]
    [Route("api/navigation")]
    public class NavigationController : ControllerBase
    {
        private readonly KclinicKclWebsiteContext _context;

        /// <summary>
        /// Constructor của NavigationController.
        /// </summary>
        /// <param name="context">Context của cơ sở dữ liệu được sử dụng để truy cập các mục điều hướng.</param>
        public NavigationController(KclinicKclWebsiteContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Lấy tất cả các mục điều hướng từ cơ sở dữ liệu và chuyển đổi chúng thành danh sách DTO.
        /// </summary>
        /// <remarks>
        /// Phương thức này truy vấn tất cả các mục điều hướng từ cơ sở dữ liệu, sau đó chuyển đổi chúng thành các đối tượng DTO.
        /// Nếu danh sách kết quả trống, phương thức sẽ trả về mã trạng thái 404 (Không tìm thấy).
        /// </remarks>
        /// <returns>Danh sách các mục điều hướng dưới dạng đối tượng JsonResult hoặc mã trạng thái 404 nếu không tìm thấy mục nào.</returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            var navigation = _context.Navigations.ToList()
                             .Select(n => n.ToNavigationDto())
                             .ToList(); // Chuyển đổi sang danh sách thực sự để kiểm tra

            if (!navigation.Any())
            {
                return NotFound(); // Trả về 404 nếu danh sách rỗng
            }

            return Ok(navigation);
        }


        /// <summary>
        /// Lấy thông tin của một mục điều hướng dựa trên ID.
        /// </summary>
        /// <param name="id">ID của mục điều hướng cần lấy.</param>
        /// <returns>
        ///     Nếu ID không hợp lệ, phương thức trả về mã trạng thái 400 Bad Request.
        ///     Nếu không tìm thấy mục điều hướng với ID tương ứng, phương thức trả về mã trạng thái 404 Not Found.
        ///     Nếu tìm thấy mục điều hướng với ID tương ứng, phương thức trả về thông tin của mục đó dưới dạng đối tượng JsonResult.
        /// </returns>
        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid id"); // Trả về lỗi nếu id không hợp lệ
            }

            var navigation = _context.Navigations.Find(id);
            if (navigation == null)
            {
                return NotFound(); // Trả về 404 nếu không tìm thấy navigation
            }

            return Ok(navigation.ToNavigationDto());
        }


        /// <summary>
        /// Tạo một mục điều hướng mới.
        /// </summary>
        /// <param name="navigationDto">Dữ liệu yêu cầu để tạo mục điều hướng mới.</param>
        /// <returns>
        ///     Nếu tạo thành công, phương thức trả về mã trạng thái 201 Created và thông tin của mục điều hướng mới được tạo dưới dạng đối tượng JsonResult,
        ///     cùng với đường dẫn đến hành động GetById để lấy thông tin chi tiết của mục điều hướng.
        /// </returns>
        [HttpPost]
        public IActionResult Create([FromBody] CreateNavigationRequestDto navigationDto)
        {
            var navigationModel = navigationDto.ToStockFromNavigationDto();
            _context.Navigations.Add(navigationModel);
            _context.SaveChanges();

            // Trả về thông báo tạo mới thành công và đường dẫn đến GetById để lấy thông tin chi tiết của mục điều hướng mới
            return CreatedAtAction(nameof(GetById), new { id = navigationModel.NavId }, navigationModel.ToNavigationDto());
        }

    }
}