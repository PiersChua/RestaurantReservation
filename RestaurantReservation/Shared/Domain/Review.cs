using RestaurantReservation.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
    public class Review
    {
        public int Id { get; set; }

        public int? Rating { get; set; }

        public DateTime? DateTime { get; set; }

        public string? Description { get; set; }

        public int? CustomerId { get; set; }

        public virtual Customer? Customer { get; set; }

        public int? RestaurantId { get; set; }

        public virtual Restaurant? Restaurant { get; set; }
    }
}
