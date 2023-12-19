using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RestaurantReservation.Server.Configurations.Entities;
using RestaurantReservation.Shared.Domain;
using RestaurantReservation.Server.Models;

namespace RestaurantReservation.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Favourite> Favourites { get; set; }
		public DbSet<Menu> Menus { get; set; }
		public DbSet<OperatingHour> OperatingHours { get; set; }
		public DbSet<PaymentMethod> PaymentMethods { get; set; }
		public DbSet<Promotion> Promotions { get; set; }
		public DbSet<Reservation> Reservations { get; set; }
		public DbSet<ReservationStatus> ReservationStatuses { get; set; }
		public DbSet<Restaurant> Restaurants { get; set; }
		public DbSet<RestaurantApplication> RestaurantApplications { get; set; }
		public DbSet<RestaurantOwner> RestaurantOwners { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<SeatingCapacity> SeatingCapacities { get; set; }
		public DbSet<Staff> Staffs { get; set; }
		public DbSet<Subscription> Subscriptions { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.ApplyConfiguration(new RestaurantSeedConfiguration());
			builder.ApplyConfiguration(new AddressSeedConfiguration());
			builder.ApplyConfiguration(new RoleSeedConfiguration());
			builder.ApplyConfiguration(new UserRoleSeedConfiguration());
			builder.ApplyConfiguration(new UserSeedConfiguration());
		}
	}

    
}