using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation.Shared.Domain;

namespace RestaurantReservation.Server.Configurations.Entities
{
    public class SeatingCapacitySeedConfiguration : IEntityTypeConfiguration<SeatingCapacity>
    {
        public void Configure(EntityTypeBuilder<SeatingCapacity> builder)
        {
            builder.HasData(
                new SeatingCapacity
                {
                    Id = 1,
                    Date = DateTime.Now,
                    Capacity = 15,
                    RestaurantId = 1
                    //hdl
                },
                new SeatingCapacity
                {
                    Id = 2,
                    Date = DateTime.Now,
                    Capacity = 15,
                    RestaurantId = 2
                    //sichuandou
                }, 
                new SeatingCapacity
                {
                    Id = 3,
                    Date = DateTime.Now,
                    Capacity = 15,
                    RestaurantId = 3
                    //beauty in the pot
                }, 
                new SeatingCapacity
                {
                    Id = 4,
                    Date = DateTime.Now,
                    Capacity = 15,
                    RestaurantId = 4
                    //shabu sai
                }, 
                new SeatingCapacity
                {
                    Id = 5,
                    Date = DateTime.Now,
                    Capacity = 15,
                    RestaurantId = 5
                    //cityhotpot
                }
                );
        }
    }
}
