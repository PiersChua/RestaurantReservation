﻿namespace RestaurantReservation.Server.Domain
{
	public class PaymentMethod
	{
		public int Id { get; set; }
		public int? CardNumber { get; set; }
		public int? DateOfExpiry { get; set; }
		public int? CVV { get; set; }
		public int CustomerId { get; set; }
		public virtual Customer? Customer { get; set; }
	}
}