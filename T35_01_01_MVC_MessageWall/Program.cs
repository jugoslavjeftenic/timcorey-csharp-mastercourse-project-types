using Microsoft.EntityFrameworkCore;
using T35_01_01_MVC_MessageWall.Areas.Identity.Data;
using T35_01_01_MVC_MessageWall.Data;
namespace T35_01_01_MVC_MessageWall
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			var connectionString = builder.Configuration.GetConnectionString("MVC_MessageWallContextConnection") ?? throw new InvalidOperationException("Connection string 'MVC_MessageWallContextConnection' not found.");

			builder.Services.AddDbContext<MVC_MessageWallContext>
				(options => options.UseSqlServer(connectionString));

			builder.Services.AddDefaultIdentity<MVC_MessageWallUser>
				(options => options.SignIn.RequireConfirmedAccount = true)
				.AddEntityFrameworkStores<MVC_MessageWallContext>();

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();
			app.UseAuthentication();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}