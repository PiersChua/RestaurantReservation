using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation.Shared.Domain;

namespace RestaurantReservation.Server.Configurations.Entities
{
    public class PromotionSeedConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.HasData(
                new Promotion
                {
                    Id = 1,
                    Name = "NewYear",//promo code name
                    Code="NY2024",//promo code
                    ImagePath="https://cdn.tatlerasia.com/tatlerasia/i/2022/12/28171650-andrew-jk-tan_cover_1500x1050.jpeg",
					Description = "Celebrate the New Year with fantastic deals! Enjoy exclusive discounts on all reservations. Start 2024 in style with limited-time offers and extra savings just for you. Renew, refresh, and rejoice! Reserve now and make this year unforgettable. Cheers to a fantastic 2024!",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddMonths(1),
                    Discount = 10
                },
                new Promotion
                {
                    Id = 2,
                    Name = "ChineseNewYear",
                    Code = "CNY2024",
                    ImagePath= "https://img.freepik.com/premium-vector/chinese-new-year-2024-with-cartoon-cute-dragon-zodiac-riding-oriental-cloud-year-dragon_438266-910.jpg",
					Description = "Celebrate the Lunar New Year at Bookbite! Reserve your table now for an exquisite culinary journey featuring luck-filled banquets and exclusive dining packages. Indulge in authentic flavors that capture the essence of the season. Make your celebrations memorable with us. Gong Xi Fa Cai!",
                    StartDate = DateTime.Now.AddMonths(1),
                    EndDate = DateTime.Now.AddMonths(2),
                    Discount = 10
                },
                new Promotion
                {
                    Id = 3,
                    Name = "Valentine",
                    Code = "LOVE2024",
                    ImagePath= "https://www.daysoftheyear.com/cdn-cgi/image/dpr=1%2Cf=auto%2Cfit=cover%2Cheight=650%2Cq=40%2Csharpen=1%2Cwidth=956/wp-content/uploads/valentines-day-concept-2021-12-14-20-37-41-utc-scaled.jpg",
					Description = "Celebrate love at Bookbite! Book your romantic evening for an unforgettable Valentine's experience. Indulge in exquisite dining with our special menu, crafted to ignite the flames of love. Enjoy a romantic ambiance and impeccable service, setting the stage for a memorable evening. Delight in exclusive dishes designed to make hearts flutter. Love is in the air at Bookbite!",
                    StartDate = DateTime.Now.AddMonths(2),
                    EndDate = DateTime.Now.AddMonths(3),
                    Discount = 10
                }
                );  
        }
    }
}