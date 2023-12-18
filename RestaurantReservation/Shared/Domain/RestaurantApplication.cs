﻿using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Server.Domain
{
	public class RestaurantApplication
	{
        public string? RestaurantName { get; set; }
		public string? Email { get; set; }
		public string? Cuisine { get; set; }
		public int? PhoneNumber { get; set; }
		public string? Description { get; set; }
		public string? Status { get; set; }
		public int CustomerId { get; set; }
		public virtual Customer? Customer { get; set;}
		public int StaffId { get; set; }
		public virtual Staff? Staff { get; set; }

    }
}