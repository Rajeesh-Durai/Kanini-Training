using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KaniniProjectAPI.Models
{
    public class QuestionType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string QuestionTypes { get; set; } = string.Empty;
        public ICollection<AddQuestion>? AddQuestions { get; set; }
    }
}
