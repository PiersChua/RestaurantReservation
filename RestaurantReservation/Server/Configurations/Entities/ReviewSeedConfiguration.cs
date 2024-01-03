using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation.Shared.Domain;

namespace RestaurantReservation.Server.Configurations.Entities
{
    public class ReviewSeedConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(
                new Review
                {
                    Id  = 1,
                    Rating = 4,
                    DateTime = DateTime.Now,
                    Description = "Hai di lao staff very attentive",
                    CustomerId = null,
                    RestaurantId = 1,
                    //haidilao
                },
                new Review
                {
                    Id = 2,
                    Rating = 4,
                    DateTime = DateTime.Now,
                    Description = "Good food",
                    CustomerId = null,
                    RestaurantId = 2,
                    //Si chuan dou hua
                },
                new Review
                {
                    Id = 3,
                    Rating = 4,
                    DateTime = DateTime.Now,
                    Description = "Nice soup",
                    CustomerId = null,
                    RestaurantId = 3
                    //beauty in the pot
                },
                new Review
                {
                    Id = 4,
                    Rating = 4,
                    DateTime = DateTime.Now,
                    Description = "Cheap and affordable",
                    CustomerId = null,
                    RestaurantId = 4
                    //shabu sai
                },
                new Review
                {
                    Id = 5,
                    Rating = 4,
                    DateTime = DateTime.Now,
                    Description = "Great restaurant",
                    CustomerId = null,
                    RestaurantId = 5
                    //city hotpot
                }
                );
        }
    }
}