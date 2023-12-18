using Microsoft.AspNetCore.Identity;

namespace RestaurantReservation.Server.Domain
{
	public class Customer : IdentityUser
	{
		/*Primary Id, Email, password, and phone number are inherited from IdentityUser*/
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Gender { get; set; }
		public string? Status { get; set; }
	}
}
