using RestaurantReservation.Shared.Domain;
using Microsoft.AspNetCore.Http;
using RestaurantReservation.Server.IRepository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservation.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Address> Addresses { get; }
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Favourite> Favourites { get; }
        IGenericRepository<Menu> Menus { get; }
        IGenericRepository<OperatingHour> OperatingHours { get; }
        IGenericRepository<PaymentMethod> PaymentMethods { get; }
        IGenericRepository<Promotion> Promotions { get; }
        IGenericRepository<Reservation> Reservations { get; }
        IGenericRepository<ReservationStatus> ReservationStatuses { get; }
        IGenericRepository<Restaurant> Restaurants { get; }
        IGenericRepository<RestaurantApplication> RestaurantApplications { get; }
        IGenericRepository<RestaurantOwner> RestaurantOwners { get; }
        IGenericRepository<Review> Reviews { get; }
        IGenericRepository<SeatingCapacity> SeatingCapacities { get; }
        IGenericRepository<Staff> Staffs { get; }
        IGenericRepository<Subscription> Subscriptions { get; }

    }
}