using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TheatherWebProject.Data;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class ServiceCollectionExtension
	{
		public static IServiceCollection AddApplicationServices (this IServiceCollection services)
		{
			return services;
		}

		public static IServiceCollection AddApplicationDbContext (this IServiceCollection services, IConfiguration config)
		{
			var connectionString = config.GetConnectionString("DefaultConnection");
			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(connectionString));

			//add Repository here

			services.AddDatabaseDeveloperPageExceptionFilter();

			return services;
		}

		public static IServiceCollection AddApplicationIdentity (this IServiceCollection services, ConfigurationManager configuration)
		{
			services.AddDefaultIdentity<IdentityUser>(options =>
			{
				options.SignIn.RequireConfirmedAccount = true;
				options.Password.RequireDigit = true;
				options.Password.RequireLowercase = true;
				options.Password.RequireUppercase = true;
				options.Password.RequiredLength = 8;
				options.User.RequireUniqueEmail = true;
			})
			.AddRoles<IdentityRole>()
			.AddEntityFrameworkStores<ApplicationDbContext>();

			return services;
		}
	}
}
