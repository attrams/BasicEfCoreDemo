using BasicEfCoreDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicEfCoreDemo.Data;

public class InvoiceDbContext(DbContextOptions<InvoiceDbContext> options) : DbContext(options)
{
    public DbSet<Invoice> Invoices => Set<Invoice>();
    public DbSet<InvoiceItem> InvoiceItems => Set<InvoiceItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Invoice>().HasData(
            new Invoice
            {
                Id = Guid.Parse("b96a0992-c9f5-4430-bac4-dffde81a1ce0"),
                InvoiceNumber = "INV-001",
                ContactName = "Iron Man",
                Description = "Invoice for the first month",
                Amount = 100,
                InvoiceDate = new DateTimeOffset(2024, 1, 1, 0, 0, 0, TimeSpan.Zero),
                DueDate = new DateTimeOffset(2024, 1, 15, 0, 0, 0, TimeSpan.Zero),
                Status = InvoiceStatus.AwaitPayment
            },
            new Invoice
            {
                Id = Guid.Parse("2ff93a99-615b-46fb-9c4f-117249c40c79"),
                InvoiceNumber = "INV-002",
                ContactName = "Captain America",
                Description = "Invoice for shield repair",
                Amount = 200,
                InvoiceDate = new DateTimeOffset(2024, 2, 1, 0, 0, 0, TimeSpan.Zero),
                DueDate = new DateTimeOffset(2024, 2, 15, 0, 0, 0, TimeSpan.Zero),
                Status = InvoiceStatus.Paid
            },
            new Invoice
            {
                Id = Guid.Parse("1418a5bb-dd74-44f0-9a32-8ab322539e2f"),
                InvoiceNumber = "INV-003",
                ContactName = "Thor",
                Description = "Invoice for hammer maintenance",
                Amount = 300,
                InvoiceDate = new DateTimeOffset(2024, 3, 1, 0, 0, 0, TimeSpan.Zero),
                DueDate = new DateTimeOffset(2024, 3, 15, 0, 0, 0, TimeSpan.Zero),
                Status = InvoiceStatus.AwaitPayment
            },
            new Invoice
            {
                Id = Guid.Parse("8c162fa2-ad58-4eb6-92b8-49d8609017fa"),
                InvoiceNumber = "INV-004",
                ContactName = "Hulk",
                Description = "Invoice for lab experiments",
                Amount = 400,
                InvoiceDate = new DateTimeOffset(2024, 4, 1, 0, 0, 0, TimeSpan.Zero),
                DueDate = new DateTimeOffset(2024, 4, 15, 0, 0, 0, TimeSpan.Zero),
                Status = InvoiceStatus.Overdue
            },
            new Invoice
            {
                Id = Guid.Parse("14a8c771-8d29-4126-bb48-e96121a2a61d"),
                InvoiceNumber = "INV-005",
                ContactName = "Black Widow",
                Description = "Invoice for tactical supplies",
                Amount = 150,
                InvoiceDate = new DateTimeOffset(2024, 5, 1, 0, 0, 0, TimeSpan.Zero),
                DueDate = new DateTimeOffset(2024, 5, 15, 0, 0, 0, TimeSpan.Zero),
                Status = InvoiceStatus.Paid
            },
            new Invoice
            {
                Id = Guid.Parse("2510f16f-4f7f-482f-a047-c07ab6021ed0"),
                InvoiceNumber = "INV-006",
                ContactName = "Hawkeye",
                Description = "Invoice for arrow replenishment",
                Amount = 120,
                InvoiceDate = new DateTimeOffset(2024, 6, 1, 0, 0, 0, TimeSpan.Zero),
                DueDate = new DateTimeOffset(2024, 6, 15, 0, 0, 0, TimeSpan.Zero),
                Status = InvoiceStatus.AwaitPayment
            }
        );
    }
}