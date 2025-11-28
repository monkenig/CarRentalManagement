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
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "54dd4079-cfce-4f27-a1d6-6a8b10066630", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMp5VUcTVrPdiPNs+CG39nZZo5mxtP0M9J+HIBmrDKPU0E634TtZYZUKHzO6OwPwUw==", null, false, "ef68faee-9dd2-49c2-bacb-07c692800c5b", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 22, 104, DateTimeKind.Local).AddTicks(3233), new DateTime(2025, 11, 28, 16, 7, 22, 104, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 22, 104, DateTimeKind.Local).AddTicks(3243), new DateTime(2025, 11, 28, 16, 7, 22, 104, DateTimeKind.Local).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 22, 104, DateTimeKind.Local).AddTicks(3382), new DateTime(2025, 11, 28, 16, 7, 22, 104, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 22, 104, DateTimeKind.Local).AddTicks(3384), new DateTime(2025, 11, 28, 16, 7, 22, 104, DateTimeKind.Local).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 22, 104, DateTimeKind.Local).AddTicks(3441), new DateTime(2025, 11, 28, 16, 7, 22, 104, DateTimeKind.Local).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 22, 104, DateTimeKind.Local).AddTicks(3442), new DateTime(2025, 11, 28, 16, 7, 22, 104, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 22, 104, DateTimeKind.Local).AddTicks(3444), new DateTime(2025, 11, 28, 16, 7, 22, 104, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 16, 7, 22, 104, DateTimeKind.Local).AddTicks(3445), new DateTime(2025, 11, 28, 16, 7, 22, 104, DateTimeKind.Local).AddTicks(3446) });

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

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 25, 42, 313, DateTimeKind.Local).AddTicks(5796), new DateTime(2025, 11, 28, 15, 25, 42, 313, DateTimeKind.Local).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 25, 42, 313, DateTimeKind.Local).AddTicks(5810), new DateTime(2025, 11, 28, 15, 25, 42, 313, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 25, 42, 313, DateTimeKind.Local).AddTicks(5955), new DateTime(2025, 11, 28, 15, 25, 42, 313, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 25, 42, 313, DateTimeKind.Local).AddTicks(5957), new DateTime(2025, 11, 28, 15, 25, 42, 313, DateTimeKind.Local).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 25, 42, 313, DateTimeKind.Local).AddTicks(6014), new DateTime(2025, 11, 28, 15, 25, 42, 313, DateTimeKind.Local).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 25, 42, 313, DateTimeKind.Local).AddTicks(6016), new DateTime(2025, 11, 28, 15, 25, 42, 313, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 25, 42, 313, DateTimeKind.Local).AddTicks(6017), new DateTime(2025, 11, 28, 15, 25, 42, 313, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 28, 15, 25, 42, 313, DateTimeKind.Local).AddTicks(6018), new DateTime(2025, 11, 28, 15, 25, 42, 313, DateTimeKind.Local).AddTicks(6019) });
        }
    }
}
