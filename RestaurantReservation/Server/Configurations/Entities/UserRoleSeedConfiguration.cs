using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace RestaurantReservation.Server.Configurations.Entities
{
	public class UserRoleSeedConfiguration :
   IEntityTypeConfiguration<IdentityUserRole<string>>
	{
		public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
		{
			builder.HasData(
			new IdentityUserRole<string>
			{
				RoleId = "69d41a28-6af8-47fe-aa0c-7785bd7233f5",
				UserId = "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb"
			}
			);
		}
	}
}
