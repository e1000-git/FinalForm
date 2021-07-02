using System;
using System.Collections.Generic;

#nullable disable

namespace Final_FootballReserve.Models
{
    public partial class Reservation
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int StadiumId { get; set; }
        public int RoomId { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public int? TimeId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }
        public virtual Stadium Stadium { get; set; }
        public virtual TimeZone Time { get; set; }
    }
}
