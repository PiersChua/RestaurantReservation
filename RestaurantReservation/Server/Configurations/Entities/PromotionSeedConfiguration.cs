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
                    Description = "New year discount!",
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddMonths(1),
                    Discount = 10
                },
                new Promotion
                {
                    Id = 2,
                    Name = "ChineseNewYear",
                    Description = "Chinese New Year discount!",
                    StartDate = DateTime.Now.AddMonths(1),
                    EndDate = DateTime.Now.AddMonths(2),
                    Discount = 10
                },
                new Promotion
                {
                    Id = 3,
                    Name = "Valentine",
                    Description = "Valentine's discount!",
                    StartDate = DateTime.Now.AddMonths(2),
                    EndDate = DateTime.Now.AddMonths(3),
                    Discount = 10
                }
                );  
        }
    }
}