using RestaurantReservation.Shared.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
    public class Review
    {
        public int Id { get; set; }
        [Required]
        public int? Rating { get; set; }

        public DateTime DateTime { get; set; }
        [Required]
		[StringLength(300, MinimumLength = 2, ErrorMessage = "Please write a longer description!")]
		public string? Description { get; set; }

        public int? CustomerId { get; set; }

        public virtual Customer? Customer { get; set; }

        public int? RestaurantId { get; set; }

        public virtual Restaurant? Restaurant { get; set; }
        public string? Username { get; set; }
    }
}
