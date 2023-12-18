using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
    public class Subscription
    {   
        public int Id { get; set; } 

        public double? PlatformFee { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public virtual List<Restaurant>? Restaurants { get; set;}

    }
}
