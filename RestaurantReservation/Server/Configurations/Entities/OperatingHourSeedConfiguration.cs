using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation.Shared.Domain;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RestaurantReservation.Server.Configurations.Entities
{
    public class OperatingHourSeedConfiguration : IEntityTypeConfiguration<OperatingHour>
    {
        public void Configure(EntityTypeBuilder<OperatingHour> builder)
        {
            builder.HasData(
                new OperatingHour
                {
                    Id = 1,
                    Day = "Monday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 1,
                    //haidilao
                },
                new OperatingHour
                {
                    Id = 2,
                    Day = "Tuesday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 1,
                    //haidilao
                },
                new OperatingHour
                {
                    Id = 3,
                    Day = "Wednesday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 1,
                    //haidilao
                },
                new OperatingHour
                {
                    Id = 4,
                    Day = "Thursday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 1,
                    //haidilao
                },
                new OperatingHour
                {
                    Id = 5,
                    Day = "Friday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 1,
                    //haidilao
                },
                new OperatingHour
                {
                    Id = 6,
                    Day = "Saturday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 1,
                    //haidilao
                },
                new OperatingHour
                {
                    Id = 7,
                    Day = "Sunday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 1,
                    //haidilao
                },

                new OperatingHour
                {
                    Id = 8,
                    Day = "Monday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 2,
                    //Si chuan dou hua
                },
                new OperatingHour
                {
                    Id = 9,
                    Day = "Tuesday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 2,
                    //Si chuan dou hua
                },
                new OperatingHour
                {
                    Id = 10,
                    Day = "Wednesday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 2,
                    //Si chuan dou hua
                },
                new OperatingHour
                {
                    Id = 11,
                    Day = "Thursday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 2,
                    //Si chuan dou hua
                },
                new OperatingHour
                {
                    Id = 12,
                    Day = "Friday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 2,
                    //Si chuan dou hua
                },
                new OperatingHour
                {
                    Id = 13,
                    Day = "Saturday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 2,
                    //Si chuan dou hua
                },
                new OperatingHour
                {
                    Id = 14,
                    Day = "Sunday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 2,
                    //Si chuan dou hua
                },

                new OperatingHour
                {
                    Id = 15,
                    Day = "Monday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 3,
                    //beauty in the pot
                },
                new OperatingHour
                {
                    Id = 16,
                    Day = "Tuesday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 3,
                    //beauty in the pot
                },
                new OperatingHour
                {
                    Id = 17,
                    Day = "Wednesday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 3,
                    //beauty in the pot
                },
                new OperatingHour
                {
                    Id = 18,
                    Day = "Thursday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 3,
                    //beauty in the pot
                },
                new OperatingHour
                {
                    Id = 19,
                    Day = "Friday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 3,
                    //beauty in the pot
                },
                new OperatingHour
                {
                    Id = 20,
                    Day = "Saturday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 3,
                    //beauty in the pot
                },
                new OperatingHour
                {
                    Id = 21,
                    Day = "Sunday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 3,
                    //beauty in the pot
                },

                new OperatingHour
                {
                    Id = 22,
                    Day = "Monday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 4
                    //shabu sai
                },
                new OperatingHour
                {
                    Id = 23,
                    Day = "Tuesday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 4
                    //shabu sai
                },
                new OperatingHour
                {
                    Id = 24,
                    Day = "Wednesday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 4
                    //shabu sai
                },
                new OperatingHour
                {
                    Id = 25,
                    Day = "Thursday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 4
                    //shabu sai
                },
                new OperatingHour
                {
                    Id = 26,
                    Day = "Friday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 4
                    //shabu sai
                },
                new OperatingHour
                {
                    Id = 27,
                    Day = "Saturday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 4
                    //shabu sai
                },
                new OperatingHour
                {
                    Id = 28,
                    Day = "Sunday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 4
                    //shabu sai
                },

                new OperatingHour
                {
                    Id = 29,
                    Day = "Monday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 5
                    //city hotpot
                },
                new OperatingHour
                {
                    Id = 30,
                    Day = "Tuesday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 5,
                    //beauty in the pot
                },
                new OperatingHour
                {
                    Id = 31,
                    Day = "Wednesday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 5
                    //city hotpot
                },
                new OperatingHour
                {
                    Id = 32,
                    Day = "Thursday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 5
                    //city hotpot
                },
                new OperatingHour
                {
                    Id = 33,
                    Day = "Friday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 5
                    //city hotpot
                },
                new OperatingHour
                {
                    Id = 34,
                    Day = "Saturday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 5
                    //city hotpot
                },
                new OperatingHour
                {
                    Id = 35,
                    Day = "Sunday",
                    OpeningTime = new DateTime(2024, 1, 1, 10, 0, 0),
                    ClosingTime = new DateTime(2024, 1, 1, 23, 0, 0),
                    RestaurantId = 5
                    //city hotpot
                }
                );
        }
    }
}