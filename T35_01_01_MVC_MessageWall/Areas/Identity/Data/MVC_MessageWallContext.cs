using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using T35_01_01_MVC_MessageWall.Areas.Identity.Data;

namespace T35_01_01_MVC_MessageWall.Data;

public class MVC_MessageWallContext : IdentityDbContext<MVC_MessageWallUser>
{
    public MVC_MessageWallContext(DbContextOptions<MVC_MessageWallContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
