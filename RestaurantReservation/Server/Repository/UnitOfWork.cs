using RestaurantReservation.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Server.IRepository;
using RestaurantReservation.Server.Models;
using RestaurantReservation.Server.Repository;
using RestaurantReservation.Shared.Domain;

namespace RestaurantReservationServer.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Address> _addresses;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Favourite> _favourites;
        private IGenericRepository<Menu> _menu;
        private IGenericRepository<OperatingHour> _operatinghours;
        private IGenericRepository<PaymentMethod> _paymentmethods;
        private IGenericRepository<Promotion> _promotions;
        private IGenericRepository<Reservation> _reservations;
        private IGenericRepository<ReservationStatus> _reservationstatuses;
        private IGenericRepository<Restaurant> _restaurants;
        private IGenericRepository<RestaurantApplication> _restaurantapplications;
        private IGenericRepository<RestaurantOwner> _restaurantowners;
        private IGenericRepository<Review> _reviews;
        private IGenericRepository<SeatingCapacity> _seatingcapacities;
        private IGenericRepository<Staff> _staffs;
        private IGenericRepository<Subscription> _subscriptions;


        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IGenericRepository<Address> Addresses
            => _addresses ??= new GenericRepository<Address>(_context);
        public IGenericRepository<Customer> Customers
            => _customers ??= new GenericRepository<Customer>(_context);
        public IGenericRepository<Favourite> Favourites
            => _favourites ??= new GenericRepository<Favourite>(_context);
        public IGenericRepository<Menu> Menus
            => _menu ??= new GenericRepository<Menu>(_context);
        public IGenericRepository<OperatingHour> OperatingHours
            => _operatinghours ??= new GenericRepository<OperatingHour>(_context);
        public IGenericRepository<PaymentMethod> PaymentMethods
            => _paymentmethods ??= new GenericRepository<PaymentMethod>(_context);
        public IGenericRepository<Promotion> Promotions
            => _promotions ??= new GenericRepository<Promotion>(_context);
        public IGenericRepository<Reservation> Reservations
            => _reservations ??= new GenericRepository<Reservation>(_context);
        public IGenericRepository<ReservationStatus> ReservationStatuses
            => _reservationstatuses ??= new GenericRepository<ReservationStatus>(_context);
        public IGenericRepository<Restaurant> Restaurants
            => _restaurants ??= new GenericRepository<Restaurant>(_context);
        public IGenericRepository<RestaurantApplication> RestaurantApplications
            => _restaurantapplications ??= new GenericRepository<RestaurantApplication>(_context);
        public IGenericRepository<RestaurantOwner> RestaurantOwners
            => _restaurantowners ??= new GenericRepository<RestaurantOwner>(_context);
        public IGenericRepository<Review> Reviews
            => _reviews ??= new GenericRepository<Review>(_context);
        public IGenericRepository<SeatingCapacity> SeatingCapacities
            => _seatingcapacities ??= new GenericRepository<SeatingCapacity>(_context);
        public IGenericRepository<Staff> Staffs
            => _staffs ??= new GenericRepository<Staff>(_context);
        public IGenericRepository<Subscription> Subscriptions
            => _subscriptions ??= new GenericRepository<Subscription>(_context);


        

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}