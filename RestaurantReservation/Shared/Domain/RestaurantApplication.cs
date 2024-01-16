using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
	public class RestaurantApplication
	{
		public int Id { get; set; }
		[Required]
		[StringLength(100, MinimumLength = 1, ErrorMessage = "Name is too short!")]
		public string? RestaurantName { get; set; }
		[Required]
		[DataType(DataType.EmailAddress)]
		public string? Email { get; set; }
		[Required]
		public string? Cuisine { get; set; }
		[Required]
		[DataType(DataType.PhoneNumber)]
		[RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Contact Number is invalid")]
		public int? PhoneNumber { get; set; }
		[Required]
		[StringLength(300, MinimumLength = 20, ErrorMessage = "Description too short!")]
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public string? Category { get; set; }
        public string? Location { get; set; }
        public string? Status { get; set; }
		public int? CustomerId { get; set; }
        public int? AddressId { get; set; }
        public int? MenuId { get; set; }
		public int? OperatingHourId { get; set; }
        public int? SeatingCapacityId { get; set; }
        public virtual Address? Address { get; set; }
        public virtual Customer? Customer { get; set;}
		public virtual Menu? Menu { get; set;}
        public virtual OperatingHour? OperatingHour { get; set; }
		public virtual SeatingCapacity? SeatingCapacity { get; set; }
        public int? StaffId { get; set; }
		public virtual Staff? Staff { get; set; }
    }
}
