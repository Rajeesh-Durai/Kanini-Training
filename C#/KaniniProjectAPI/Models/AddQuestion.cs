﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KaniniProjectAPI.Models
{
    public class AddQuestion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("Topic")]
        public int TopicId { get; set; }
        [ForeignKey("Skill")]
        public int SkillId { get; set; }
        [ForeignKey("QuestionType")]
        public int QuestionTypeId { get; set; }
        public string Question { get; set; } = string.Empty;
        public string Option1 { get; set; } = string.Empty;
        public string Option2 { get; set; } = string.Empty;
        public string Option3 { get; set; } = string.Empty;
        public string Option4 { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
        public string Explanation { get; set; } = string.Empty;
        public ICollection<QuestionPage>? QuestionPages { get; set; }
    }
}
