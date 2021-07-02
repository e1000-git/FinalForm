using System;
using System.Collections.Generic;

#nullable disable

namespace Final_FootballReserve.Models
{
    public partial class Room
    {
        public Room()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Capacity { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
