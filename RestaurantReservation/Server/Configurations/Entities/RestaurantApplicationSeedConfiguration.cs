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
                    Category = "Hotpot",
                    Location = "East",

                    ImagePath = "/image",
                    CustomerId = null,
                    StaffId = null,
                    AddressId = null,
                    SeatingCapacityId = null,
                    OperatingHourId = null,
                    MenuId = null,
                    
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
                    Category = "Hotpot",
                    Location = "East",

                    ImagePath = "/image",
                    CustomerId = null,
                    StaffId = null,
                    AddressId = null,
                    SeatingCapacityId = null,
                    OperatingHourId = null,
                    MenuId = null,
                },
                new RestaurantApplication
                {
                    Id = 3,
                    RestaurantName = "ManNa Korean BBQ",
                    Email = "ManNa@koreanBBQ.com",
                    Cuisine = "Korea",
                    PhoneNumber = 62601838,
                    Description = "good bbq,100% must try!",
                    Status = "Active",
                    Category = "BBQ",
                    Location = "East",

                    ImagePath = "/image",
                    CustomerId = null,
                    StaffId = null,
                    AddressId = null,
                    SeatingCapacityId = null,
                    OperatingHourId = null,
                    MenuId = null,
                }

                );

        }
    }
}
