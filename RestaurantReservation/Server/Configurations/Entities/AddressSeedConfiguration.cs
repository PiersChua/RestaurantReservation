using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation.Shared.Domain;

namespace RestaurantReservation.Server.Configurations.Entities
{
	public class AddressSeedConfiguration : IEntityTypeConfiguration<Address>
	{
		public void Configure(EntityTypeBuilder<Address> builder)
		{
			builder.HasData(
				new Address
				{
					Id=1,
					Street= "2 Tampines Central 5",
					Building= "Century Square",
					Level= 2,
					UnitNumber= "#02-22",
					PostalCode= 529509
				},
				new Address
				{
					Id=2,
					Street= "7500 Beach Rd",
					Building= "Parkroyal",
					Level= 1,
					UnitNumber= null,
					PostalCode= 199591
				},
				new Address
				{
					Id = 3,
					Street = "1 HarbourFront Walk",
					Building = "VivoCity",
					Level = 3,
					UnitNumber = "#03-08A",
					PostalCode = 098585
				},
				new Address
				{
					Id=4,
					Street= " 10 Tampines Central 1",
					Building= "Tampines 1",
					Level= 2,
					UnitNumber= "#02-04",
					PostalCode= 529536
				},
				new Address
				{
					Id=5,
					Street= "1 Raffles Place",
					Building= "One Raffles Place",
					Level= 4,
					UnitNumber= "#04-26/27/28",
					PostalCode= 048616
				},
				new Address
				{
					Id = 6,
					Street = "291 New Bridge Rd",
					Building = "Oriental plaza",
					Level = 1,
					UnitNumber = "#01-01",
					PostalCode = 088756
				},
				new Address
				{
					Id = 7,
					Street = "300 Tampines Ave 5",
					Building = "NTUC Income Tampines Junction",
					Level = 1,
					UnitNumber = "#01-06",
					PostalCode = 529653
				},
				new Address
				{
					Id = 8,
					Street = "53 Ang Mo Kio Ave 3",
					Building = "AMK Hub",
					Level = 4,
					UnitNumber = "#04-04",
					PostalCode = 569933
				},
				new Address
				{
					Id = 9,
					Street = " 68 Orchard Rd",
					Building = "Plaza Singapura",
					Level = 2,
					UnitNumber = "#02-01",
					PostalCode = 238839
				},
				new Address
				{
					Id = 10,
					Street = "4 Tampines Central 5",
					Building = "Tampines Mall",
					Level = 4,
					UnitNumber = "#04-01",
					PostalCode = 529510
				}

				);
		}
	}
}
