using BasicEfCoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicEfCoreDemo.Data;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("Addresses");
        builder.HasKey(address => address.Id);
        builder.Property(address => address.Street).IsRequired();
        builder.Property(address => address.City).IsRequired();
        builder.Property(address => address.State).IsRequired();
        builder.Property(address => address.ZipCode).IsRequired();
        builder.Property(address => address.Country);
        builder.Property(address => address.ContactId).IsRequired();
        builder.Ignore(address => address.Contact);
        builder.HasOne(address => address.Contact)
            .WithOne(contact => contact.Address)
            .HasForeignKey<Address>(address => address.ContactId);
    }
}