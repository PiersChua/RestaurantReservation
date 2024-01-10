using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation.Shared.Domain;

namespace RestaurantReservation.Server.Configurations.Entities
{
    public class MenuSeedConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasData(
                new Menu
                {
                    Id = 1,
                    ImagePath = "images/haidilaoMenu.jpg",
                    RestaurantId = 1
                },
                new Menu
                {
                    Id = 2,
                    ImagePath = "images/sichuandouhuaMenu.jpg",
                    RestaurantId = 2
                },
                new Menu
                {
                    Id = 3,
                    ImagePath = "images/beautyinthepotMenu.jpg",
                    RestaurantId = 3
                },
                new Menu
                {
                    Id = 4,
                    ImagePath = "images/shabusaiMenu.jpg",
                    RestaurantId = 4
                },
                new Menu
                {
                    Id = 5,
                    ImagePath = "images/cityhotpotMenu.jpg",
                    RestaurantId = 5
                },
				new Menu
				{
					Id = 6,
					ImagePath = "images/ssikkekMenu.jpg",
					RestaurantId = 6
				},
				new Menu
				{
					Id = 7,
					ImagePath = "images/captainkimMenu.jpeg",
					RestaurantId = 7
				},
				new Menu
				{
					Id = 8,
					ImagePath = "images/imkimkoreanMenu.jpg",
					RestaurantId = 8
				},
				new Menu
				{
					Id = 9,
					ImagePath = "images/seoraeMenu.jpg",
					RestaurantId = 9
				},
				new Menu
				{
					Id = 10,
					ImagePath = "images/seoulgardenMenu.png",
					RestaurantId = 10
				}
				);

        }
    }
}
