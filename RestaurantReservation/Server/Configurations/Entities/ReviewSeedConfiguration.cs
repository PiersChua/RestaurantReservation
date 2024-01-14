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
                },
				new Review
				{
					Id = 6,
					Rating = 5,
					DateTime = DateTime.Now,
					Description = "Excellent service and outstanding food!",
					CustomerId = null,
					RestaurantId = 1,
					//haidilao
				},
				new Review
				{
					Id = 7,
					Rating = 3,
					DateTime = DateTime.Now,
					Description = "Good experience with room for improvement",
					CustomerId = null,
					RestaurantId = 1,
					//haidilao
				},
				new Review
				{
					Id = 8,
					Rating = 1,
					DateTime = DateTime.Now,
					Description = "Disappointing experience. Not recommended.",
					CustomerId = null,
					RestaurantId = 2,
					//Si chuan dou hua
				},
				new Review
				{
					Id = 9,
					Rating = 5,
					DateTime = DateTime.Now,
					Description = "Amazing ambiance and top-notch cuisine!",
					CustomerId = null,
					RestaurantId = 2,
					//Si chuan dou hua
				},
				new Review
				{
					Id = 10,
					Rating = 2,
					DateTime = DateTime.Now,
					Description = "Satisfactory visit but lacks a wow factor.",
					CustomerId = null,
					RestaurantId = 3,
				},
				new Review
				{
					Id = 11,
					Rating = 1,
					DateTime = DateTime.Now,
					Description = "Unpleasant experience. Would not recommend",
					CustomerId = null,
					RestaurantId = 3,
				},
				new Review
				{
					Id = 12,
					Rating = 1,
					DateTime = DateTime.Now,
					Description = "Satisfactory visit but lacks a wow factor.",
					CustomerId = null,
					RestaurantId = 4,
				},
				new Review
				{
					Id = 13,
					Rating = 5,
					DateTime = DateTime.Now,
					Description = "Outstanding service and exquisite dishes!",
					CustomerId = null,
					RestaurantId = 4,
				},
				new Review
				{
					Id = 14,
					Rating = 1,
					DateTime = DateTime.Now,
					Description = "Poor service and disappointing menu",
					CustomerId = null,
					RestaurantId = 5,
				},
				new Review
				{
					Id = 15,
					Rating = 5,
					DateTime = DateTime.Now,
					Description = "Exceptional dining experience with impeccable service!",
					CustomerId = null,
					RestaurantId = 5,
				},
				new Review
				{
					Id = 16,
					Rating = 5,
					DateTime = DateTime.Now,
					Description = "Superb service and a menu that delights the taste buds!",
					CustomerId = null,
					RestaurantId = 6,
				},
				new Review
				{
					Id = 17,
					Rating = 3,
					DateTime = DateTime.Now,
					Description = "Adequate experience, but lacks a special touch",
					CustomerId = null,
					RestaurantId = 6,
				},
				new Review
				{
					Id = 18,
					Rating = 1,
					DateTime = DateTime.Now,
					Description = "Awful service and disappointing overall.",
					CustomerId = null,
					RestaurantId = 6,
				},
				new Review
				{
					Id = 19,
					Rating = 5,
					DateTime = DateTime.Now,
					Description = "Superb service and a menu that delights the taste buds!",
					CustomerId = null,
					RestaurantId = 7,
				},
				new Review
				{
					Id = 20,
					Rating = 3,
					DateTime = DateTime.Now,
					Description = "Adequate experience, but lacks a special touch",
					CustomerId = null,
					RestaurantId = 7,
				},
				new Review
				{
					Id = 21,
					Rating = 1,
					DateTime = DateTime.Now,
					Description = "Awful service and disappointing overall.",
					CustomerId = null,
					RestaurantId = 7,
				},
				new Review
				{
					Id = 22,
					Rating = 5,
					DateTime = DateTime.Now,
					Description = "Superb service and a menu that delights the taste buds!",
					CustomerId = null,
					RestaurantId = 8,
				},
				new Review
				{
					Id = 23,
					Rating = 3,
					DateTime = DateTime.Now,
					Description = "Adequate experience, but lacks a special touch",
					CustomerId = null,
					RestaurantId = 8,
				},
				new Review
				{
					Id = 24,
					Rating = 1,
					DateTime = DateTime.Now,
					Description = "Awful service and disappointing overall.",
					CustomerId = null,
					RestaurantId = 8,
				},
				new Review
				{
					Id = 25,
					Rating = 5,
					DateTime = DateTime.Now,
					Description = "Superb service and a menu that delights the taste buds!",
					CustomerId = null,
					RestaurantId = 9,
				},
				new Review
				{
					Id = 26,
					Rating = 3,
					DateTime = DateTime.Now,
					Description = "Adequate experience, but lacks a special touch",
					CustomerId = null,
					RestaurantId = 9,
				},
				new Review
				{
					Id = 27,
					Rating = 1,
					DateTime = DateTime.Now,
					Description = "Awful service and disappointing overall.",
					CustomerId = null,
					RestaurantId = 9,
				}

				);
        }
    }
}