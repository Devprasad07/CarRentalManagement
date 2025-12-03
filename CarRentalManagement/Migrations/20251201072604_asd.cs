using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class asd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5aa237af-efe0-4a4c-804a-90d2b24ef6d2", "AQAAAAIAAYagAAAAELNOxFSNr+6Pd8V5e+47GJP3k+Xzbpsvta1GaLbmuYWxrsKkQKZt9oFKNAdk8GzTdw==", "00741c00-ef1e-4215-a964-7c8ca05aa6cc" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 15, 26, 3, 377, DateTimeKind.Local).AddTicks(3011), new DateTime(2025, 12, 1, 15, 26, 3, 377, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 15, 26, 3, 377, DateTimeKind.Local).AddTicks(3028), new DateTime(2025, 12, 1, 15, 26, 3, 377, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 15, 26, 3, 377, DateTimeKind.Local).AddTicks(3221), new DateTime(2025, 12, 1, 15, 26, 3, 377, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 15, 26, 3, 377, DateTimeKind.Local).AddTicks(3223), new DateTime(2025, 12, 1, 15, 26, 3, 377, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 15, 26, 3, 377, DateTimeKind.Local).AddTicks(3318), new DateTime(2025, 12, 1, 15, 26, 3, 377, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 15, 26, 3, 377, DateTimeKind.Local).AddTicks(3320), new DateTime(2025, 12, 1, 15, 26, 3, 377, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 15, 26, 3, 377, DateTimeKind.Local).AddTicks(3322), new DateTime(2025, 12, 1, 15, 26, 3, 377, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 1, 15, 26, 3, 377, DateTimeKind.Local).AddTicks(3323), new DateTime(2025, 12, 1, 15, 26, 3, 377, DateTimeKind.Local).AddTicks(3324) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Customer");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f58143a0-aee7-47f3-bf4c-bac62d31e3e0", "AQAAAAIAAYagAAAAEI0o6EuMs2T3IDpSAQeaXVaJhSgq+Ce4LRTlVVPK4tZAQx+8w5w7OTb+romJs1OUzg==", "6b038122-d90d-4cf7-8c3e-9c2f08239ad4" });

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
        }
    }
}
