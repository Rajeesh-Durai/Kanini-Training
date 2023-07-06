using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Example1.Models
{
    public class Post
    {
        [Key]
        int PostId { get; set; }
        [Required]
        public string Title { get; set; }= string.Empty;
        [ForeignKey(nameof(Users))]
        public int UserId { get; set; }
        [ForeignKey(nameof(Groups))]
        public int GroupId { get; set; }
    }
}
