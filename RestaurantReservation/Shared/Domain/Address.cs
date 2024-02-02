using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
    public class Address
    {
        public int Id { get; set; }
        [Required]
        public string? Street { get; set; }
        [Required]
        public string? Building { get; set; }
        [Required]
        public int? Level { get; set; }
        public string? UnitNumber { get; set; }
        [Required]
        [RegularExpression(@"^\d{6}$",ErrorMessage ="Invalid postal code")]
        public int? PostalCode { get; set; }

    }
}
