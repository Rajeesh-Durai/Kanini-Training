using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KaniniProjectAPI.Models
{
    public class QuestionPage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("AddQuestion")]
        public int AddQuestionId { get; set; }
        [ForeignKey("Assessment")]
        public string? AssessmentId { get; set; }
    }
}
