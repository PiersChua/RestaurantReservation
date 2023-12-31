using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation.Shared.Domain;

namespace RestaurantReservation.Server.Configurations.Entities
{
    public class FavouriteSeedConfiguration : IEntityTypeConfiguration<Favourite>
    {
        public void Configure(EntityTypeBuilder<Favourite> builder)
        {
            builder.HasData(
                new Favourite
                {
                    Id = 1,
                    Name = "Hai Di Lao",
                    RestaurantId = 1,
                    CustomerId = null,
                },
                new Favourite
                {
                    Id = 2,
                    Name = "Hai Di Lao",
                    RestaurantId = 2,
                    //Si chuan dou hua
                    CustomerId = null,
                },
                new Favourite
                {
                    Id = 3,
                    Name = "Hai Di Lao",
                    RestaurantId = 3,
                    //beauty in the pot
                    CustomerId = null,
                },
                new Favourite
                {
                    Id = 4,
                    Name = "Hai Di Lao",
                    RestaurantId = 5,
                    //city hotpot
                    CustomerId = null,
                }
                );

        }
    }
}
