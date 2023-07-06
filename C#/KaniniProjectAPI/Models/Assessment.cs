using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KaniniProjectAPI.Models
{
    public class Assessment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = string.Empty;

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("Topic")]
        public int TopicId { get; set; }
        [ForeignKey("Skill")]
        public int SkillId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public int NumberOfTopics { get; set; }
        public int NumberOfQuestions { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateOfCreation { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateOfCompletion { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public int? Score { get; set; }
        public int? CorrectAnswer { get; set; }
        public int? WrongAnswer { get; set; }
        public int? SkippedAnswer { get; set; }
        public ICollection<QuestionPage>? QuestionPages { get; set; }
        public ICollection<UserAssessment>? UserAssessments { get; set; }
    }
}
