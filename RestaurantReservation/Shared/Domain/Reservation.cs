using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
	public class Reservation
	{
		public int Id { get; set; }
		public DateTime? DateTime { get; set; }
		public int? Guest { get; set; }
		public string? Request { get; set; }
		public int CustomerId { get; set; }
		public virtual Customer? Customer { get; set; }
		public int RestaurantId { get; set; }
		public virtual Restaurant? Restaurant { get; set; }
		public int PromotionId { get; set; }
		public virtual Promotion? Promotion { get; set; }
		public int ReservationStatusId { get; set; }
		public virtual ReservationStatus? ReservationStatus { get; set; }
	}
}
