using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleProject.Models
{
    public class ScreenDetails
    {
        [Key]
        public int ScreenId { get; set; }
        [Required]       

        public DateTime ShowTime { get; set; }

        public int SeatNo { get; set; }
        [Required]
        public string SeatType { get; set; } = string.Empty;
        [Required]
        public int Price { get; set; }

        public string SeatStatus { get; set; } = string.Empty;
        public ICollection<MovieDetails>? Movies { get; set; }
        public ICollection<BookingDetails>? BookingDetails { get; set; }

    }
}
