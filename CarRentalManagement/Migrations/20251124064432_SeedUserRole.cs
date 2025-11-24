using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "f58143a0-aee7-47f3-bf4c-bac62d31e3e0", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEI0o6EuMs2T3IDpSAQeaXVaJhSgq+Ce4LRTlVVPK4tZAQx+8w5w7OTb+romJs1OUzg==", null, false, "6b038122-d90d-4cf7-8c3e-9c2f08239ad4", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 44, 32, 210, DateTimeKind.Local).AddTicks(9965), new DateTime(2025, 11, 24, 14, 44, 32, 210, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 44, 32, 210, DateTimeKind.Local).AddTicks(9981), new DateTime(2025, 11, 24, 14, 44, 32, 210, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 44, 32, 211, DateTimeKind.Local).AddTicks(167), new DateTime(2025, 11, 24, 14, 44, 32, 211, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 44, 32, 211, DateTimeKind.Local).AddTicks(168), new DateTime(2025, 11, 24, 14, 44, 32, 211, DateTimeKind.Local).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 44, 32, 211, DateTimeKind.Local).AddTicks(254), new DateTime(2025, 11, 24, 14, 44, 32, 211, DateTimeKind.Local).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 44, 32, 211, DateTimeKind.Local).AddTicks(255), new DateTime(2025, 11, 24, 14, 44, 32, 211, DateTimeKind.Local).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 44, 32, 211, DateTimeKind.Local).AddTicks(257), new DateTime(2025, 11, 24, 14, 44, 32, 211, DateTimeKind.Local).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 44, 32, 211, DateTimeKind.Local).AddTicks(258), new DateTime(2025, 11, 24, 14, 44, 32, 211, DateTimeKind.Local).AddTicks(258) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 26, 36, 886, DateTimeKind.Local).AddTicks(2286), new DateTime(2025, 11, 24, 14, 26, 36, 886, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 26, 36, 886, DateTimeKind.Local).AddTicks(2303), new DateTime(2025, 11, 24, 14, 26, 36, 886, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 26, 36, 886, DateTimeKind.Local).AddTicks(2495), new DateTime(2025, 11, 24, 14, 26, 36, 886, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 26, 36, 886, DateTimeKind.Local).AddTicks(2497), new DateTime(2025, 11, 24, 14, 26, 36, 886, DateTimeKind.Local).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 26, 36, 886, DateTimeKind.Local).AddTicks(2580), new DateTime(2025, 11, 24, 14, 26, 36, 886, DateTimeKind.Local).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 26, 36, 886, DateTimeKind.Local).AddTicks(2582), new DateTime(2025, 11, 24, 14, 26, 36, 886, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 26, 36, 886, DateTimeKind.Local).AddTicks(2583), new DateTime(2025, 11, 24, 14, 26, 36, 886, DateTimeKind.Local).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 14, 26, 36, 886, DateTimeKind.Local).AddTicks(2585), new DateTime(2025, 11, 24, 14, 26, 36, 886, DateTimeKind.Local).AddTicks(2585) });
        }
    }
}
