using BasicEfCoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicEfCoreDemo.Data;

public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.ToTable("Contacts");
        builder.HasKey(contact => contact.Id);
        builder.Property(contact => contact.FirstName).IsRequired();
        builder.Property(contact => contact.LastName).IsRequired();
        builder.Property(contact => contact.Email).IsRequired();
        builder.Property(contact => contact.Phone).IsRequired();
    }
}