using Microsoft.AspNetCore.Mvc;

namespace Example1.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentText { get; set; }=string.Empty;

    }
}
