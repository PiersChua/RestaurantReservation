﻿namespace RestaurantReservation.Shared.Domain
{
	public class Promotion
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public DateOnly StartDate { get; set; }
		public DateOnly? EndDate { get; set; }
		public double? Discount { get; set; }
	}
}
