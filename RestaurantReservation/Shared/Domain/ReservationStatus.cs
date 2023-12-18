using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
	public class ReservationStatus
	{
		public int Id { get; set; }
		public string? Status { get; set; }
		public virtual List<Reservation>? Reservations { get; set; }
	}
}
