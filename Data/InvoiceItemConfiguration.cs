using BasicEfCoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BasicEfCoreDemo.Data;

public class InvoiceItemConfiguration : IEntityTypeConfiguration<InvoiceItem>
{
    public void Configure(EntityTypeBuilder<InvoiceItem> builder)
    {
        builder.ToTable("InvoiceItems");
        builder.Property(invoiceItem => invoiceItem.Id).HasColumnName(nameof(InvoiceItem.Id));
        builder.Property(invoiceItem => invoiceItem.Name).HasColumnName(nameof(InvoiceItem.Name)).HasMaxLength(64).IsRequired();
        builder.Property(invoiceItem => invoiceItem.Description).HasColumnName(nameof(InvoiceItem.Description)).HasMaxLength(256);
        builder.Property(invoiceItem => invoiceItem.UnitPrice).HasColumnName(nameof(InvoiceItem.UnitPrice)).HasPrecision(8, 2);
        builder.Property(invoiceItem => invoiceItem.Quantity).HasColumnName(nameof(InvoiceItem.Quantity)).HasPrecision(8, 2);
        builder.Property(invoiceItem => invoiceItem.Amount).HasColumnName(nameof(InvoiceItem.Amount)).HasPrecision(18, 2);
        builder.Property(invoiceItem => invoiceItem.InvoiceId).HasColumnName(nameof(InvoiceItem.InvoiceId));
    }
}