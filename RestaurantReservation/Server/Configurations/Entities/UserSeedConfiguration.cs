using RestaurantReservation.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RestaurantReservation.Server.Configurations.Entities
{
	public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
	{
		public void Configure(EntityTypeBuilder<ApplicationUser> builder)
		{
			var hasher = new PasswordHasher<ApplicationUser>();
			builder.HasData(
			new ApplicationUser
			{
				Id = "900de75c-2b44-4069-8c0d-d7d3a7ae4ffb",
				Email = "admin@localhost.com",
				NormalizedEmail = "ADMIN@LOCALHOST.COM",
				UserName = "admin@localhost.com",
				NormalizedUserName = "ADMIN@LOCALHOST.COM",
				PasswordHash = hasher.HashPassword(null, "P@ssword1")
			}
			);
		}
	}
}
