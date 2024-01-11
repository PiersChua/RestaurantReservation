using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation.Shared.Domain;

namespace RestaurantReservation.Server.Configurations.Entities
{
    public class ReservationStatusSeedConfiguration : IEntityTypeConfiguration<ReservationStatus>
    {
        public void Configure(EntityTypeBuilder<ReservationStatus> builder)
        {
            builder.HasData(
                new ReservationStatus
                {
                    Id = 1,
                    Status = "Pending"
                },
                new ReservationStatus
                {
                    Id = 2,
                    Status = "Confirmed"
                },
                new ReservationStatus
                {
                    Id = 3,
                    Status = "Cancelled"
                }
                );

        }
    }
}
