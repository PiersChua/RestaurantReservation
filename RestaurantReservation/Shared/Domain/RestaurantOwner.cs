using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
	public class RestaurantOwner
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public virtual Customer? Customer { get; set; }
		public virtual List<Restaurant>? Restaurants { get; set; }
	}
}
