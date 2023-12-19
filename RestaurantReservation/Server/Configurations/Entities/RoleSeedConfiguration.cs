using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace RestaurantReservation.Server.Configurations.Entities
{
	public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
	{
		public void Configure(EntityTypeBuilder<IdentityRole> builder)
		{
			builder.HasData(
			new IdentityRole
			{
				Id = "69d41a28-6af8-47fe-aa0c-7785bd7233f5",
				Name = "Staff",
				NormalizedName = "STAFF"
			},
			new IdentityRole
			{
				Id = "f0926ab0-0927-48bb-8f5a-92a5d1acbade",
				Name = "Customer",
				NormalizedName = "CUSTOMER"
			}
			);
		}
	}
}