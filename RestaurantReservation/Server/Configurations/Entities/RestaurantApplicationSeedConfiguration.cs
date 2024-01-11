using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation.Shared.Domain;

namespace RestaurantReservation.Server.Configurations.Entities
{
    public class RestaurantApplicationSeedConfiguration : IEntityTypeConfiguration<RestaurantApplication>
    {
        public void Configure(EntityTypeBuilder<RestaurantApplication> builder)
        {
            builder.HasData(
                new RestaurantApplication
                { 
                    Id = 1,
                    RestaurantName = "Paradise Hotpot",
                    Email = "paradisehotpot@paradise.com",
                    Cuisine = "Chinese",
                    PhoneNumber = 63864838,
                    Description = "good hotpot,must try!",
                    Status = "Active",
                    CustomerId = null,
                    StaffId = null,
                    AddressId = null,
                },
                new RestaurantApplication
                {
                    Id = 2,
                    RestaurantName = "Shi Li Fang Hotpot",
                    Email = "slfhotpot@slf.com",
                    Cuisine = "Chinese",
                    PhoneNumber = 62601838,
                    Description = "good hotpot,must try!",
                    Status = "Active",
                    CustomerId = null,
                    StaffId = null,
                    AddressId=null,
                }
                );

        }
    }
}
