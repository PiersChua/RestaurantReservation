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
                    DishName = "HotPot",
                    Description = null,
                    Price = null,
                    AllergyContents = null,
                    ImagePath = "images/haidilaoMenu.jpg",
                    RestaurantId = 1
                },
                new Menu
                {
                    Id = 2,
                    DishName = "HotPot",
                    Description = null,
                    Price = null,
                    AllergyContents = null,
                    ImagePath = "images/sichuandouhuaMenu.jpg",
                    RestaurantId = 2
                },
                new Menu
                {
                    Id = 3,
                    DishName = "HotPot",
                    Description = null,
                    Price = null,
                    AllergyContents = null,
                    ImagePath = "images/beautyinthepotMenu.jpg",
                    RestaurantId = 3
                },
                new Menu
                {
                    Id = 4,
                    DishName = "HotPot",
                    Description = null,
                    Price = null,
                    AllergyContents = null,
                    ImagePath = "images/shabusaiMenu.jpg",
                    RestaurantId = 4
                },
                new Menu
                {
                    Id = 5,
                    DishName = "HotPot",
                    Description = null,
                    Price = null,
                    AllergyContents = null,
                    ImagePath = "images/cityhotpotMenu.jpg",
                    RestaurantId = 5
                }
                );

        }
    }
}
