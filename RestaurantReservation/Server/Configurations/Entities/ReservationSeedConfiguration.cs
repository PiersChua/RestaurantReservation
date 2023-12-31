using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation.Shared.Domain;

namespace RestaurantReservation.Server.Configurations.Entities
{
    public class ReservationSeedConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasData(
                new Reservation
                {
                    Id = 1,
                    DateTime = DateTime.Now,
                    Guest = 2,
                    Request = "None",
                    CustomerId = null,
                    RestaurantId = 1,
                    //haidilao
                    PromotionId = null,
                    ReservationStatusId = 1
                },
                new Reservation
                {
                    Id = 2,
                    DateTime = DateTime.Now,
                    Guest = 3,
                    Request = "None",
                    CustomerId = null,
                    RestaurantId = 2,
                    //Si chuan dou hua
                    PromotionId = null,
                    ReservationStatusId = 2
                },
                new Reservation
                {
                    Id = 3,
                    DateTime = DateTime.Now,
                    Guest = 4,
                    Request = "None",
                    CustomerId = null,
                    RestaurantId = 3,
                    //beauty in the pot
                    PromotionId = null,
                    ReservationStatusId = 3
                },
                new Reservation
                {
                    Id = 4,
                    DateTime = DateTime.Now,
                    Guest = 2,
                    Request = "None",
                    CustomerId = null,
                    RestaurantId = 5,
                    //city hotpot
                    PromotionId = null,
                    ReservationStatusId = 4
                }
                );
        }
    }
}
