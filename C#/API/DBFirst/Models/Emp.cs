using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SecAPI.Models;

public partial class Emp
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Eno { get; set; }

    public string Ename { get; set; } = null!;

    public int Ph { get; set; }

    public int? Deptno { get; set; }

    public string? Desig { get; set; }

    public virtual Dept? DeptnoNavigation { get; set; }
}
