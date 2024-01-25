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
                    RestaurantId = 1,
                    CustomerId = null,
                    Username = "admin@localhost.com"
                },
                new Favourite
                {
                    Id = 2,
                    RestaurantId = 2,
                    //Si chuan dou hua
                    CustomerId = null,
					Username = "admin@localhost.com"
				},
                new Favourite
                {
                    Id = 3,
                    RestaurantId = 3,
                    //beauty in the pot
                    CustomerId = null,
					Username = "admin@localhost.com"
				},
                new Favourite
                {
                    Id = 4,
                    RestaurantId = 5,
                    //city hotpot
                    CustomerId = null,
					Username = "admin@localhost.com"
				}
                );

        }
    }
}
