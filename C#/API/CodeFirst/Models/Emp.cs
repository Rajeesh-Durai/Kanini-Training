using System.ComponentModel.DataAnnotations.Schema;

namespace ThirdAPI.Models
{
    public class Emp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Eno { get; set; }

        public string Ename { get; set; } = null!;
        public Dept? Deptno { get; set; }
    }
}
