using System;
using System.Collections.Generic;

namespace APIProj.Models;

public partial class Seat
{
    public int SeatId { get; set; }

    public int SeatType { get; set; }

    public int TicketPrice { get; set; }

    public string SeatStatus { get; set; } = null!;

    public virtual ICollection<BookingDetaill> BookingDetaills { get; set; } = new List<BookingDetaill>();

    public virtual ICollection<Theatre> Theatres { get; set; } = new List<Theatre>();
}
