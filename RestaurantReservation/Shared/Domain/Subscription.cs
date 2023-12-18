﻿using System;
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

        public DateOnly? StartDate { get; set; }

        public DateOnly? EndDate { get; set; }

        public virtual List<Restaurant>? Restaurants { get; set;}

    }
}
