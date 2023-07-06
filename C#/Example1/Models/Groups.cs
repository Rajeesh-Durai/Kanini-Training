using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Example1.Models
{
    public class Groups
    {
        [Key]
        public int GroupId { get; set; }

        [ForeignKey(nameof(Users))]
        public int UserId { get; set; }
    }
}
