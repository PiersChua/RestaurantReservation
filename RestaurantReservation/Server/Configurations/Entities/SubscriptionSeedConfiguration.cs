using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation.Shared.Domain;

namespace RestaurantReservation.Server.Configurations.Entities
{
    public class SubscriptionSeedConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            builder.HasData(
                new Subscription
                {
                    Id = 1,
                    PlatformFee = 10.00,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Subscription
                {
                    Id = 2,
                    PlatformFee = 10.00,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Subscription
                {
                    Id = 3,
                    PlatformFee = 10.00,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Subscription
                {
                    Id = 4,
                    PlatformFee = 10.00,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Subscription
                {
                    Id = 5,
                    PlatformFee = 10.00,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },

                new Subscription
                {
                    Id = 6,
                    PlatformFee = 10.00,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Subscription
                {
                    Id = 7,
                    PlatformFee = 10.00,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Subscription
                {
                    Id = 8,
                    PlatformFee = 10.00,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Subscription
                {
                    Id = 9,
                    PlatformFee = 10.00,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Subscription
                {
                    Id = 10,
                    PlatformFee = 10.00,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Subscription
                {
                    Id = 11,
                    PlatformFee = 10.00,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Subscription
                {
                    Id = 12,
                    PlatformFee = 10.00,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Subscription
                {
                    Id = 13,
                    PlatformFee = 10.00,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Subscription
                {
                    Id = 14,
                    PlatformFee = 10.00,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                },
                new Subscription
                {
                    Id = 15,
                    PlatformFee = 10.00,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                }

                );
        }
    }
}
