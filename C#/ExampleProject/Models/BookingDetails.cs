using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleProject.Models
{
    public class BookingDetails

    {
        [Key]
        public int BookingId { get; set; }
        [ForeignKey(nameof(Login))]
        public int UserId { get; set; }
        [ForeignKey(nameof(MovieDetails))]
        public int MovieId { get; set; }
        [ForeignKey(nameof(ScreenDetails))]
        public int ScreenId { get; set; }
        [Column(TypeName = "Date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]

        public DateTime BookingDate { get; set; }


    }
}
