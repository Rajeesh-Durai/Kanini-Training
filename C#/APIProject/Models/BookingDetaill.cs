using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APIProject.Models;

public partial class BookingDetaill
{
    public int LoginId { get; set; }

    public int MovieId { get; set; }

    public int TheatreId { get; set; }

    public int SeatId { get; set; }


    [Key]
    public DateTime BookingDate { get; set; }

    public virtual LogIn Login { get; set; } = null!;

    public virtual Movie Movie { get; set; } = null!;

    public virtual Seat Seat { get; set; } = null!;

    public virtual Theatre Theatre { get; set; } = null!;
}
