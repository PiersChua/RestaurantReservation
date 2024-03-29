﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Cuisine { get; set; }
        [Required]
        public string? Category { get; set; }
        [Required]
        public int? PhoneNumber { get; set; }
        [Required]
        public string? Location { get; set; } // North south east west
		public string? ImagePath { get; set; }
        public string? Status { get; set; }
        public int? AddressId { get; set; }
        public virtual Address? Address { get; set; }
        public int? RestaurantOwnerId { get; set; }
        public virtual RestaurantOwner? RestaurantOwner { get; set; }
        public int? SubscriptionId { get; set; }
        public virtual Subscription? Subscription { get; set; }
        public virtual List<Reservation>? Reservations { get; set;}
        public virtual List<Favourite>? Favourites { get; set; }
        public virtual List<Review>? Reviews { get; set; }
        public virtual List<Menu>? Menus { get; set; }
        public virtual List<OperatingHour>? OperatingHours { get; set; }
        public virtual List<SeatingCapacity>? SeatingCapacities { get; set; }

    }
}
