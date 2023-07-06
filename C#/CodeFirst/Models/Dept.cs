
namespace ThirdAPI.Models
{
    public class Dept
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptNo { get; set; }
      
        public string DeptName { get; set;}=string.Empty;
       
        public ICollection<Dept>? Depts { get; set; }
    }
}
