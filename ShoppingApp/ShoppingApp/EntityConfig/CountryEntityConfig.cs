using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Models.Entity;

public class CountryEntityConfig : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.ToTable("Country");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name)
               .IsRequired()
               .HasMaxLength(255);

        builder.Property(c => c.Code)
               .HasMaxLength(50);

        builder.HasMany(c => c.StateNavigation)
               .WithOne(s => s.CountryNavigation)
               .HasForeignKey(s => s.CountryId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
