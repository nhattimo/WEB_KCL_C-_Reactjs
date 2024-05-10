using KCL_Web.Server.Dtos.NavList;
using KCL_Web.Server.Models;

namespace KCL_Web.Server.Mappers
{
    public static class NavListMapper
    {
        public static NavListDto ToNavListDto(this NavList navListModel)
        {
            return new NavListDto
            {
                NavListId = navListModel.NavListId,
                Title = navListModel.Title,
                Url = navListModel.Url,
                NavId = navListModel.NavId

            };
        }
        public static NavList ToNavListFromCreateDto(this CreateNavListDto navListDto, int navigdtionId)
        {
            return new NavList
            {
                Title = navListDto.Title,
                Url = navListDto.Url,
                NavId = navigdtionId
            };
        }

        public static NavList ToNavListFromUpdateDto(this UpdateNavListRequestDto navListDto, int navigdtionId)
        {
            return new NavList
            {
                Title = navListDto.Title,
                Url = navListDto.Url,
                NavId = navigdtionId
            };
        }


    }
}