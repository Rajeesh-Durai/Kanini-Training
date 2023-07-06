using System.ComponentModel.DataAnnotations;

namespace ExampleProject.Models
{
    public class Login
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage ="Username Required")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password Required")]
        public string Password { get; set; }= string.Empty;
        public ICollection<BookingDetails>? BookingDetails { get; set; }

    }
}
