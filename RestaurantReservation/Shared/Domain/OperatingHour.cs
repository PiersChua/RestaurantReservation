using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
    public class OperatingHour
    {
        public int Id { get; set; }

        public string? Day { get; set; }

        public DateTime? OpeningTime { get; set; }

        public DateTime? ClosingTime { get; set; }

        public int? RestaurantId { get; set; }

        public virtual Restaurant? Restaurant { get; set; }

    }
}
