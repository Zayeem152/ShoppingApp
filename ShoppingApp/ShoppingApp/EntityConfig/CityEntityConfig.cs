using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Models.Entity;

public class CityEntityConfig : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.ToTable("City");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name)
               .IsRequired()
               .HasMaxLength(255);

        builder.Property(c => c.Code)
               .HasMaxLength(50);

        builder.HasMany(c => c.UserNavigation)
               .WithOne(u => u.CityNavigation)
               .HasForeignKey(u => u.CityId)
               .OnDelete(DeleteBehavior.SetNull);
    }
}
