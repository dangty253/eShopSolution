using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("164a2f46-b29b-4f10-a96a-6b070385eff4"),
                column: "ConcurrencyStamp",
                value: "5b7c54b0-6d16-4249-bcff-3398e6268716");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6af6883c-622a-4af0-8e04-0857b140ae52"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69de4ace-21c6-4ec5-9080-53161fd24ff8", "AQAAAAEAACcQAAAAEH9KOAFwbnS0V/E1cGCHObIL+TZQgU6XrbdvdhVg0GsxlbPim2yK8R3ZpjvS5jvM/w==" });

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
                value: new DateTime(2020, 4, 11, 22, 13, 39, 113, DateTimeKind.Local).AddTicks(3002));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("164a2f46-b29b-4f10-a96a-6b070385eff4"),
                column: "ConcurrencyStamp",
                value: "f5bf7fcd-099b-4135-9573-e825612518f2");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6af6883c-622a-4af0-8e04-0857b140ae52"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "63c1f8f5-4185-46ef-825c-fb8fbc15a7ab", "AQAAAAEAACcQAAAAEIwqK/AIPoQ4Boh9uRnrIOvKotRqBA91zOnC3mpIJS1sdaenm443A5Z/fkFA8Hds5w==" });

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
                value: new DateTime(2020, 4, 10, 9, 22, 33, 164, DateTimeKind.Local).AddTicks(7754));
        }
    }
}
