using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
    public class OperatingHour
    {
        public int Id { get; set; }

        public string? Day { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime? OpeningTime { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime? ClosingTime { get; set; }

        public int? RestaurantId { get; set; }

        public virtual Restaurant? Restaurant { get; set; }

    }
}
