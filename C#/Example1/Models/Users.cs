using System.ComponentModel.DataAnnotations;

namespace Example1.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; } = string.Empty;

        public ICollection<Post>? Posts { get; set; }
    }
}
