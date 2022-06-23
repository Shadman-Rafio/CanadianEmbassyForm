using CanadianEmbassyForm.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CanadianEmbassyForm.Data;

public class CanadianEmbassyFormContext : IdentityDbContext<CanadianEmbassyFormUser>
{
    public CanadianEmbassyFormContext(DbContextOptions<CanadianEmbassyFormContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
}

internal class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<CanadianEmbassyFormUser>
{
    void IEntityTypeConfiguration<CanadianEmbassyFormUser>.Configure(EntityTypeBuilder<CanadianEmbassyFormUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(50);
        builder.Property(u => u.LastName).HasMaxLength(50);
    }
}