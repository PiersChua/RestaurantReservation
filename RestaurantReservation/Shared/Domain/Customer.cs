﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
	public class Customer
	{
		public int Id { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Email { get; set; }
		public string? Password { get; set; }
		public string? Gender { get; set; }
		public int? PhoneNumber { get; set; }
		public string? Status { get; set; }
		public virtual List<Reservation>? Reservations { get; set; }
		public virtual List<Favourite>? Favourites { get; set; }
		public virtual List<RestaurantApplication>? RestaurantApplications { get; set; }	
		public virtual List<PaymentMethod>? PaymentMethods { get; set; }
		public virtual List<Review>? Reviews { get; set; }
	}
}
