using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleProject.Models
{
    public class MovieDetails
    {
        [Key]
        public int MovieId { get; set; }
        [Required]
        public string MovieName { get; set; }  = string.Empty;
        [Required]
        public string MovieLanguage { get; set;} = string.Empty;
        [Required]
        [Column(TypeName = "Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }
       
        [ForeignKey(nameof(ScreenDetails))]
        public int ScreenId { get; set; }
       
        public ICollection<BookingDetails>? Bookings { get; set; }

    }
}
