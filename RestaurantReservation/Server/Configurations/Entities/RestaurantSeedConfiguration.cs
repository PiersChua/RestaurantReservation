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
					Email = "admissions@tp.edu.sg",
					Cuisine = "Chinese",
					Category="Hotpot",
					PhoneNumber= 67804201,
					Location= "East",
					ImagePath= "images/haidilao.jpg",
					AddressId = 1,
					RestaurantOwnerId = null,
					SubscriptionId = null

				},
				new Restaurant
				{
					Id = 2,
					Name = "Si Chuan Dou Hua",
                    Email = "admissions@tp.edu.sg",
                    Cuisine = "Chinese",
					Category = "Hotpot",
					PhoneNumber = 67804201,
					Location= "Central",
					ImagePath = "images/sichuandouhua.jpg",
					AddressId = 2,
					RestaurantOwnerId = null,
					SubscriptionId = null
				},
				new Restaurant
				{
					Id = 3,
					Name = "Beauty In The Pot",
                    Email = "admissions@tp.edu.sg",
                    Cuisine = "Chinese",
					Category = "Hotpot",
					PhoneNumber = 67804201,
					Location="South",
					ImagePath = "images/beautyinthepot.jpg",
					AddressId = 3,
					RestaurantOwnerId = null,
					SubscriptionId = null
				},
				new Restaurant
				{
					Id = 4,
					Name = "Shabu Sai",
                    Email = "admissions@tp.edu.sg",
                    Cuisine = "Chinese",
					Category = "Hotpot",
					PhoneNumber = 67804201,
					Location="East",
					ImagePath = "images/shabusai.jpg",
					AddressId = 4,
					RestaurantOwnerId = null,
					SubscriptionId = null
				},
				new Restaurant
				{
					Id = 5,
					Name = "City Hotpot",
                    Email = "admissions@tp.edu.sg",
                    Cuisine = "Chinese",
					Category = "Hotpot",
					PhoneNumber = 67804201,
					Location="SouthWest",
					ImagePath = "images/cityhotpot.jpg",
					AddressId = 5,
					RestaurantOwnerId = null,
					SubscriptionId = null
				},
				new Restaurant
				{
					Id = 6,
					Name = "Ssikkek",
					Email = "admissions@tp.edu.sg",
					Cuisine = "Korea",
					Category = "BBQ",
					PhoneNumber = 67804201,
					Location = "Central",
					ImagePath = "images/ssikkek.jpg",
					AddressId = 6,
					RestaurantOwnerId = null,
					SubscriptionId = null
				},
				new Restaurant
				{
					Id = 7,
					Name = "Captain Kim",
					Email = "admissions@tp.edu.sg",
					Cuisine = "Korea",
					Category = "BBQ",
					PhoneNumber = 67804201,
					Location = "East",
					ImagePath = "images/captainkim.jpg",
					AddressId = 7,
					RestaurantOwnerId = null,
					SubscriptionId = null
				},
				new Restaurant
				{
					Id = 8,
					Name = "I'm Kim Korean",
					Email = "admissions@tp.edu.sg",
					Cuisine = "Korea",
					Category = "BBQ",
					PhoneNumber = 67804201,
					Location = "North",
					ImagePath = "images/imkimkorean.jpg",
					AddressId = 8,
					RestaurantOwnerId = null,
					SubscriptionId = null
				},
				new Restaurant
				{
					Id = 9,
					Name = "Seorae",
					Email = "admissions@tp.edu.sg",
					Cuisine = "Korea",
					Category = "BBQ",
					PhoneNumber = 67804201,
					Location = "Central",
					ImagePath = "images/seorae.jpg",
					AddressId = 9,
					RestaurantOwnerId = null,
					SubscriptionId = null
				},
				new Restaurant
				{
					Id = 10,
					Name = "Seoul Garden",
					Email = "admissions@tp.edu.sg",
					Cuisine = "Korea",
					Category = "BBQ",
					PhoneNumber = 67804201,
					Location = "East",
					ImagePath = "images/seoulgarden.jpg",
					AddressId = 10,
					RestaurantOwnerId = null,
					SubscriptionId = null
				}



				);
		}
	}
}
