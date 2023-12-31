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
                }
                );
        }
    }
}
