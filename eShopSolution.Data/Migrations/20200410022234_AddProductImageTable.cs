using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 3, 29, 22, 4, 41, 564, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 3, 29, 22, 4, 41, 564, DateTimeKind.Local).AddTicks(8213),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("164a2f46-b29b-4f10-a96a-6b070385eff4"),
                column: "ConcurrencyStamp",
                value: "cef43d03-ccec-45ab-b4fc-a6859a0892a4");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("6af6883c-622a-4af0-8e04-0857b140ae52"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "285c2a73-93c2-4075-a114-ce8ad50eccde", "AQAAAAEAACcQAAAAEKXdDh1Ue5Njy7FmXeBi2ApfX+fUtftTGylkm1F6dYPITjDclwcEuz+xwacX81c7ig==" });

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
    }
}
