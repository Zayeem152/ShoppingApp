using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Models.Entity;

public class StateEntityConfig : IEntityTypeConfiguration<State>
{
    public void Configure(EntityTypeBuilder<State> builder)
    {
        builder.ToTable("State");

        builder.HasKey(s => s.Id);

        builder.Property(s => s.Name)
               .IsRequired()
               .HasMaxLength(255);

        builder.Property(s => s.Code)
               .HasMaxLength(50);

        builder.HasMany(s => s.CityNavigation)
               .WithOne(c => c.StateNavigation)
               .HasForeignKey(c => c.StateId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
