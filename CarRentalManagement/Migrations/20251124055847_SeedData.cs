using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DataCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 13, 58, 47, 319, DateTimeKind.Local).AddTicks(3884), new DateTime(2025, 11, 24, 13, 58, 47, 319, DateTimeKind.Local).AddTicks(3897), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 13, 58, 47, 319, DateTimeKind.Local).AddTicks(3900), new DateTime(2025, 11, 24, 13, 58, 47, 319, DateTimeKind.Local).AddTicks(3900), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DataCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 13, 58, 47, 319, DateTimeKind.Local).AddTicks(4088), new DateTime(2025, 11, 24, 13, 58, 47, 319, DateTimeKind.Local).AddTicks(4089), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 13, 58, 47, 319, DateTimeKind.Local).AddTicks(4090), new DateTime(2025, 11, 24, 13, 58, 47, 319, DateTimeKind.Local).AddTicks(4090), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DataCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 13, 58, 47, 319, DateTimeKind.Local).AddTicks(4169), new DateTime(2025, 11, 24, 13, 58, 47, 319, DateTimeKind.Local).AddTicks(4169), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 13, 58, 47, 319, DateTimeKind.Local).AddTicks(4171), new DateTime(2025, 11, 24, 13, 58, 47, 319, DateTimeKind.Local).AddTicks(4171), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 13, 58, 47, 319, DateTimeKind.Local).AddTicks(4172), new DateTime(2025, 11, 24, 13, 58, 47, 319, DateTimeKind.Local).AddTicks(4172), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 13, 58, 47, 319, DateTimeKind.Local).AddTicks(4173), new DateTime(2025, 11, 24, 13, 58, 47, 319, DateTimeKind.Local).AddTicks(4174), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
