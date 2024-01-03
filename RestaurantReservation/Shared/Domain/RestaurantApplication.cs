using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
	public class RestaurantApplication
	{
		public int Id { get; set; }
        public string? RestaurantName { get; set; }
		public string? Email { get; set; }
		public string? Cuisine { get; set; }
		public int? PhoneNumber { get; set; }
		public string? Description { get; set; }
		public string? Status { get; set; }
        public int? AddressId { get; set; }
        public virtual Address? Address { get; set; }
        public int? CustomerId { get; set; }
		public virtual Customer? Customer { get; set;}
		public int? StaffId { get; set; }
		public virtual Staff? Staff { get; set; }
    }
}
