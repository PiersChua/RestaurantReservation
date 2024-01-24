using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
	public class PaymentMethod
	{
		public int Id { get; set; }

        [Required]
        [StringLength(32, MinimumLength = 2, ErrorMessage = "Name does not meet length requirements")]
        public string? Name { get; set; }

        [Required]
        [RegularExpression(@"^\d{16}$", ErrorMessage = "Invalid Card Credentials")]
        public string? CardNumber { get; set; }

		[Required]
		public DateTime? DateOfExpiry { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}$", ErrorMessage = "Invalid CVV")]
        public int? CVV { get; set; }

		public int? CustomerId { get; set; }
		public virtual Customer? Customer { get; set; }
        public string? Username { get; set; }
	}
}
