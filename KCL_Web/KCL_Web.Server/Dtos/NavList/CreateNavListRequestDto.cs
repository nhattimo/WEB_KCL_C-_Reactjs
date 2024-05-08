namespace KCL_Web.Server.Dtos.NavList
{
    public class CreateNavListRequestDto
    {
        public string? Title { get; set; }

        public string? Url { get; set; }

        public int? NavId { get; set; }
    }
}