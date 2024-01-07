﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
	public class Promotion
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Code { get; set; }
		public string? Description { get; set; }
		public DateTime? StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		public double? Discount { get; set; }
	}
}
