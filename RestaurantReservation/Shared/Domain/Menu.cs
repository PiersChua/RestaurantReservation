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

        public string? DishName { get; set; }

        public string? Description { get; set; }

        public double? Price { get; set; }

        public string? AllergyContents { get; set; }

        public int RestaurantId { get; set; }

        public virtual Restaurant? Restaurant { get; set; }
    }
}
