using System;
using System.Collections.Generic;

namespace APIProj.Models;

public partial class BookingDetaill
{
    public int LoginId { get; set; }

    public int MovieId { get; set; }

    public int TheatreId { get; set; }

    public int SeatId { get; set; }

    public DateTime BookingDate { get; set; }

    

    public virtual Movie Movie { get; set; } = null!;

    public virtual Seat Seat { get; set; } = null!;

    public virtual Theatre Theatre { get; set; } = null!;
}
