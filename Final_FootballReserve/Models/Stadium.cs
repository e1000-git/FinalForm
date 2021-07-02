using System;
using System.Collections.Generic;

#nullable disable

namespace Final_FootballReserve.Models
{
    public partial class Stadium
    {
        public Stadium()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
