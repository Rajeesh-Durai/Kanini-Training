using System;
using System.Collections.Generic;

namespace APIProj.Models;

public partial class ShowTime
{
    public int ShowId { get; set; }

    public string ShowTime1 { get; set; } = null!;

    public virtual ICollection<Theatre> Theatres { get; set; } = new List<Theatre>();
}
