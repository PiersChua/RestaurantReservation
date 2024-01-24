using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation.Shared.Domain;

namespace RestaurantReservation.Server.Configurations.Entities
{
    public class PaymentMethodSeedConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasData(
                new PaymentMethod
                {
                    Id = 1,
                    Name="Josh",
                    CardNumber = "1234123412341234",
                    DateOfExpiry = DateTime.Now.AddYears(1),
                    CVV = 123,
                    CustomerId = null,
					Username = "admin@localhost.com"
				}, 
                new PaymentMethod
                {
                    Name = "Liza",
                    Id = 2,
                    CardNumber = "1234123412341234",
                    DateOfExpiry = DateTime.Now.AddYears(1),
                    CVV = 321,
                    CustomerId = null,
					Username = "admin@localhost.com"
				}

                );
            

        }
    }
}
