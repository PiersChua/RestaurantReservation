namespace RestaurantReservation.Server.Domain
{
	public class Promotion
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public string? StartDate { get; set; }
		public string? EndDate { get; set; }
		public int? Discount { get; set; }
	}
}
