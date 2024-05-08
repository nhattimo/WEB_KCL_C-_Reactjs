namespace KCL_Web.Server.Dtos.Comment
{
    public class CommentDto
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Conten { get; set; } = null!;

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public int? StockId { get; set; }

    }
}