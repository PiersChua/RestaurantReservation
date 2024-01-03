using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
    public class Menu
    {
        public int Id { get; set; }
		public string? ImagePath { get; set; }
		public int? RestaurantId { get; set; }

        public virtual Restaurant? Restaurant { get; set; }
    }
}
