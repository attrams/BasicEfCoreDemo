using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BasicEfCoreDemo.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "Amount", "ContactName", "Description", "DueDate", "InvoiceDate", "InvoiceNumber", "Status" },
                values: new object[,]
                {
                    { new Guid("1418a5bb-dd74-44f0-9a32-8ab322539e2f"), 300m, "Thor", "Invoice for hammer maintenance", new DateTimeOffset(new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "INV-003", 1 },
                    { new Guid("14a8c771-8d29-4126-bb48-e96121a2a61d"), 150m, "Black Widow", "Invoice for tactical supplies", new DateTimeOffset(new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "INV-005", 2 },
                    { new Guid("2510f16f-4f7f-482f-a047-c07ab6021ed0"), 120m, "Hawkeye", "Invoice for arrow replenishment", new DateTimeOffset(new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "INV-006", 1 },
                    { new Guid("2ff93a99-615b-46fb-9c4f-117249c40c79"), 200m, "Captain America", "Invoice for shield repair", new DateTimeOffset(new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "INV-002", 2 },
                    { new Guid("8c162fa2-ad58-4eb6-92b8-49d8609017fa"), 400m, "Hulk", "Invoice for lab experiments", new DateTimeOffset(new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "INV-004", 3 },
                    { new Guid("b96a0992-c9f5-4430-bac4-dffde81a1ce0"), 100m, "Iron Man", "Invoice for the first month", new DateTimeOffset(new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "INV-001", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("1418a5bb-dd74-44f0-9a32-8ab322539e2f"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("14a8c771-8d29-4126-bb48-e96121a2a61d"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("2510f16f-4f7f-482f-a047-c07ab6021ed0"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("2ff93a99-615b-46fb-9c4f-117249c40c79"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("8c162fa2-ad58-4eb6-92b8-49d8609017fa"));

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: new Guid("b96a0992-c9f5-4430-bac4-dffde81a1ce0"));
        }
    }
}
