using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
	public class PaymentMethod
	{
		public int Id { get; set; }
		public int? CardNumber { get; set; }
		public DateTime? DateOfExpiry { get; set; }
		public int? CVV { get; set; }
		public int CustomerId { get; set; }
		public virtual Customer? Customer { get; set; }
	}
}
