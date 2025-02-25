﻿namespace KCL_Web.Server.Dtos.Post
{
    public class AddingPost
    {
        public string? Title { get; set; }

        public string? Content { get; set; }

        public string? IntroContent { get; set; }
        public IFormFile? Image { get; set; }
        public string? ImageUrl { get; set; }

        public DateTime? PostDate { get; set; }

        public string? AuthorName { get; set; }

        public int? CategoryId { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public byte? Status { get; set; }
    }
}
