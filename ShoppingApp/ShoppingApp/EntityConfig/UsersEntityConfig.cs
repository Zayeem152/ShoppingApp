using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Models.Entity;

public class UsersEntityConfig : IEntityTypeConfiguration<Users>
{
    public void Configure(EntityTypeBuilder<Users> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(u => u.Id);

        builder.Property(u => u.Name)
               .IsRequired()
               .HasMaxLength(255);

        builder.Property(u => u.Email)
               .HasMaxLength(255);

        builder.Property(u => u.PhoneNumber)
               .HasMaxLength(50);

        builder.Property(u => u.Address)
               .HasColumnType("text");

        builder.Property(u => u.CreatedDateTime)
               .IsRequired()
               .HasDefaultValueSql("CURRENT_TIMESTAMP");

        builder.Property(u => u.ModifiedDateTime);
    }
}
