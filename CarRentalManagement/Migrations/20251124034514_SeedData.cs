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
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 45, 13, 167, DateTimeKind.Local).AddTicks(9077), new DateTime(2025, 11, 24, 11, 45, 13, 167, DateTimeKind.Local).AddTicks(9095), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 45, 13, 167, DateTimeKind.Local).AddTicks(9100), new DateTime(2025, 11, 24, 11, 45, 13, 167, DateTimeKind.Local).AddTicks(9101), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 45, 13, 167, DateTimeKind.Local).AddTicks(9499), new DateTime(2025, 11, 24, 11, 45, 13, 167, DateTimeKind.Local).AddTicks(9501), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 45, 13, 167, DateTimeKind.Local).AddTicks(9504), new DateTime(2025, 11, 24, 11, 45, 13, 167, DateTimeKind.Local).AddTicks(9505), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 45, 13, 167, DateTimeKind.Local).AddTicks(9622), new DateTime(2025, 11, 24, 11, 45, 13, 167, DateTimeKind.Local).AddTicks(9623), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 45, 13, 167, DateTimeKind.Local).AddTicks(9627), new DateTime(2025, 11, 24, 11, 45, 13, 167, DateTimeKind.Local).AddTicks(9628), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 11, 45, 13, 167, DateTimeKind.Local).AddTicks(9630), new DateTime(2025, 11, 24, 11, 45, 13, 167, DateTimeKind.Local).AddTicks(9631), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 11, 45, 13, 167, DateTimeKind.Local).AddTicks(9634), new DateTime(2025, 11, 24, 11, 45, 13, 167, DateTimeKind.Local).AddTicks(9635), "C-HR", "System" }
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
