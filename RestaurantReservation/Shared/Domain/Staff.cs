using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
    public class Staff
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public int? PhoneNumber { get; set; }

        public string? Gender { get; set;}

        public DateTime? DOB { get; set; }

        public string? NRIC { get; set; }

        public DateTime? ContactStart { get; set; }

        public DateTime? ContactEnd { get; set; }

        public string? Nationality { get; set; }   

        public virtual List<RestaurantApplication>? RestaurantApplications { get; set; }
    }
}
