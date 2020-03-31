using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 29, 22, 4, 41, 564, DateTimeKind.Local).AddTicks(8213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 29, 21, 47, 31, 854, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("164a2f46-b29b-4f10-a96a-6b070385eff4"), "cef43d03-ccec-45ab-b4fc-a6859a0892a4", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("6af6883c-622a-4af0-8e04-0857b140ae52"), new Guid("164a2f46-b29b-4f10-a96a-6b070385eff4") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirtName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("6af6883c-622a-4af0-8e04-0857b140ae52"), 0, "285c2a73-93c2-4075-a114-ce8ad50eccde", new DateTime(2020, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanhly@gmail.com", true, "Nguyen", "Ty", false, null, "thanhly@gmail.com", "admin", "AQAAAAEAACcQAAAAEKXdDh1Ue5Njy7FmXeBi2ApfX+fUtftTGylkm1F6dYPITjDclwcEuz+xwacX81c7ig==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 3, 29, 22, 4, 41, 595, DateTimeKind.Local).AddTicks(1471));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("164a2f46-b29b-4f10-a96a-6b070385eff4"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("6af6883c-622a-4af0-8e04-0857b140ae52"), new Guid("164a2f46-b29b-4f10-a96a-6b070385eff4") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6af6883c-622a-4af0-8e04-0857b140ae52"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 29, 21, 47, 31, 854, DateTimeKind.Local).AddTicks(2011),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 3, 29, 22, 4, 41, 564, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 3, 29, 21, 47, 31, 881, DateTimeKind.Local).AddTicks(3587));
        }
    }
}
