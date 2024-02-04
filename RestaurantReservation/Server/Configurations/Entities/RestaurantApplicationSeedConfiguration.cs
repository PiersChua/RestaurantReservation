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
                    Status = "Pending",
                    Category = "Hotpot",
                    Location = "East",

                    ImagePath = "images/noImage.jpg",
                    CustomerId = null,
                    SubscriptionId = 3,
                    StaffId = null,
                    AddressId = 11,
                    SeatingCapacityId = null,
                    OperatingHourId = 71,
                    MenuId = 11,
                    
                },
                new RestaurantApplication
                {
                    Id = 2,
                    RestaurantName = "Shi Li Fang Hotpot",
                    Email = "slfhotpot@slf.com",
                    Cuisine = "Chinese",
                    PhoneNumber = 62601838,
                    Description = "good hotpot,must try!",
                    Status = "Pending",
                    Category = "Hotpot",
                    Location = "East",

                    ImagePath = "images/noImage.jpg",
                    CustomerId = null,
                    SubscriptionId = 4,
                    StaffId = null,
                    AddressId = 12,
                    SeatingCapacityId = null,
                    OperatingHourId = 78,
                    MenuId = 12,
                },
                new RestaurantApplication
                {
                    Id = 3,
                    RestaurantName = "ManNa Korean BBQ",
                    Email = "ManNa@koreanBBQ.com",
                    Cuisine = "Korea",
                    PhoneNumber = 62601838,
                    Description = "good bbq,100% must try!",
                    Status = "Pending",
                    Category = "BBQ",
                    Location = "East",

                    ImagePath = "images/noImage.jpg",
                    CustomerId = null,
                    SubscriptionId = 5,
                    StaffId = null,
                    AddressId = 13,
                    SeatingCapacityId = null,
                    OperatingHourId = 85,
                    MenuId = 13,
                }
                );

        }
    }
}
