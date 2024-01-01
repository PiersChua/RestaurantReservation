using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation.Shared.Domain;

namespace RestaurantReservation.Server.Configurations.Entities
{
	public class RestaurantSeedConfiguration : IEntityTypeConfiguration<Restaurant>
	{
		public void Configure(EntityTypeBuilder<Restaurant> builder)
		{
			builder.HasData(
				new Restaurant
				{
					Id= 1,
					Name = "Hai Di Lao",
					Email=null,
					Cuisine = "Chinese",
					Category="Hotpot",
					PhoneNumber= 67804201,
					ImagePath= "images/haidilao.jpg",
					AddressId = 1,
					RestaurantOwnerId = null,
					SubscriptionId = null

				},
				new Restaurant
				{
					Id = 2,
					Name = "Si Chuan Dou Hua",
                    Email = null,
                    Cuisine = "Chinese",
					Category = "Hotpot",
					PhoneNumber = 67804201,
					ImagePath = "images/sichuandouhua.jpg",
					AddressId = 2,
					RestaurantOwnerId = null,
					SubscriptionId = null
				},
				new Restaurant
				{
					Id = 3,
					Name = "Beauty In The Pot",
                    Email = null,
                    Cuisine = "Chinese",
					Category = "Hotpot",
					PhoneNumber = 67804201,
					ImagePath = "images/beautyinthepot.jpg",
					AddressId = 3,
					RestaurantOwnerId = null,
					SubscriptionId = null
				},
				new Restaurant
				{
					Id = 4,
					Name = "Shabu Sai",
                    Email = null,
                    Cuisine = "Chinese",
					Category = "Hotpot",
					PhoneNumber = 67804201,
					ImagePath = "images/shabusai.jpg",
					AddressId = 4,
					RestaurantOwnerId = null,
					SubscriptionId = null
				},
				new Restaurant
				{
					Id = 5,
					Name = "City Hotpot",
                    Email = null,
                    Cuisine = "Chinese",
					Category = "Hotpot",
					PhoneNumber = 67804201,
					ImagePath = "images/cityhotpot.jpg",
					AddressId = 5,
					RestaurantOwnerId = null,
					SubscriptionId = null
				}



				);
		}
	}
}
