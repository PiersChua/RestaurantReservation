using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
	public class Promotion
	{
		public int Id { get; set; }
		[Required]
		public string? Name { get; set; }
		[Required]
		public string? Code { get; set; }
		[Required]
		[StringLength(1000, MinimumLength = 40, ErrorMessage = "Description too short!")]
		public string? Description { get; set; }
		[Required]
		[DataType(DataType.Date)]
		public DateTime StartDate { get; set; }
		[Required]
		[DataType(DataType.Date)]
		public DateTime EndDate { get; set; }
		[Required]
		[Range(1, 100, ErrorMessage = "Discount must be between 0 and 100")]
		public double? Discount { get; set; }
	}
}
