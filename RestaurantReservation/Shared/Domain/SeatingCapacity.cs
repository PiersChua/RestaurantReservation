using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
    public class SeatingCapacity
    {
        public int Id { get; set; }

        public DateOnly? Date { get; set; }

        public int? Capacity { get; set; }

        public int RestaurantId { get; set; }

        public virtual Restaurant? Restaurant { get; set; }
    }
}
