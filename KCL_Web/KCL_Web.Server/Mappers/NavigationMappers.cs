using KCL_Web.Server.Dtos.Navigation;
using KCL_Web.Server.Models;

namespace KCL_Web.Server.Mappers
{
    public static class NavigationMappers
    {
        /// <summary>
        /// Chuyển đổi từ một đối tượng Navigation thành một đối tượng NavigationDto.
        /// Phương thức này được sử dụng để tạo một đối tượng NavigationDto từ dữ liệu được cung cấp trong một đối tượng Navigation.
        /// </summary>
        /// <param name="navigationModel">Đối tượng Navigation chứa dữ liệu đầu vào.</param>
        /// <returns>Đối tượng NavigationDto mới được tạo ra từ dữ liệu trong đối tượng Navigation.</returns>
        public static NavigationDto ToNavigationDto(this Navigation navigationModel)
        {
            return new NavigationDto
            {
                NavId = navigationModel.NavId,
                NavTitle = navigationModel.NavTitle,
                NavUrl = navigationModel.NavUrl,
            };
        }


        /// <summary>
        /// Chuyển đổi từ một yêu cầu tạo mới NavigationDto thành một đối tượng Navigation.
        /// Phương thức này được sử dụng để tạo một đối tượng Navigation từ dữ liệu được cung cấp trong yêu cầu tạo mới.
        /// </summary>
        /// <param name="navigationDto">Yêu cầu tạo mới NavigationDto chứa dữ liệu đầu vào.</param>
        /// <returns>Đối tượng Navigation mới được tạo ra từ dữ liệu trong yêu cầu tạo mới.</returns>
        public static Navigation ToStockFromNavigationDto(this CreateNavigationRequestDto navigationDto)
        {
            return new Navigation
            {
                NavTitle = navigationDto.NavTitle,
                NavUrl = navigationDto.NavUrl,
            };
        }

    }
}