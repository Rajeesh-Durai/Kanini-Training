using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KaniniProjectAPI.Models
{
    public class Topic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TopicName { get; set; } = string.Empty;
        public ICollection<AddQuestion>? AddQuestions { get; set; }
        public ICollection<Assessment>? Assessments { get; set; }
    }
}
