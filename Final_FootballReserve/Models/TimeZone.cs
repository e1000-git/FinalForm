using System;
using System.Collections.Generic;

#nullable disable

namespace Final_FootballReserve.Models
{
    public partial class TimeZone
    {
        public TimeZone()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public string Timezone1 { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
