using System;
using System.Collections.Generic;

namespace APIProject.Models;

public partial class Seat
{
    public int SeatId { get; set; }

    public int SeatType { get; set; }

    public int TicketPrice { get; set; }

    public string SeatStatus { get; set; } = null!;

    public virtual ICollection<Theatre> Theatres { get; set; } = new List<Theatre>();
}
