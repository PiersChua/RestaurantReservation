using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
    public class Address
    {
        public int Id { get; set; }

        public string? Street { get; set; }

        public string? Building { get; set; }

        public int? Level { get; set; }

        public string? UnitNumber { get; set; }

        public int? PostalCode { get; set; }

    }
}
