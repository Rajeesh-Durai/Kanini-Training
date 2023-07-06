using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KaniniProjectAPI.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public byte[]? UserImage { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        [Column(TypeName = "Date")]
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;

        [ForeignKey("EmployeeDepartment")]
        public int? EmployeeDepartmentId { get; set; }
        public string EducationLevel { get; set; } = string.Empty;
        public string Roles { get; set; } = string.Empty;
        public string Designation { get; set; } = string.Empty;
        public int PhoneNumber { get; set; }
        public string Location { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public ICollection<Assessment>? Assessments { get; set; }
        public ICollection<UserAssessment>? UserAssessments { get; set; }
    }
}
