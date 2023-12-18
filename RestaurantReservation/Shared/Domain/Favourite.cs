namespace RestaurantReservation.Shared.Domain
{
	public class Favourite
	{
		public int Id { get; set; }
		public int RestaurantId { get; set; }
		public virtual Restaurant? Restaurant { get; set; }
		public int CustomerId { get; set; }
		public virtual Customer? Customer { get; set; }

	}
}
