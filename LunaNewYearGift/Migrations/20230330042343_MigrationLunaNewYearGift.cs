using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LunaNewYearGift.Migrations
{
    /// <inheritdoc />
    public partial class MigrationLunaNewYearGift : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customerID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    customerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    email = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true),
                    address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    numberOfOrder = table.Column<int>(type: "int", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customerID);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    orderDetailID = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    orderID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    productID = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.orderDetailID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    orderID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    customerID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    typeGiftID = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    statusID = table.Column<int>(type: "int", nullable: false),
                    orderCode = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true),
                    orderConfirm = table.Column<bool>(type: "bit", nullable: true),
                    note = table.Column<string>(type: "nvarchar(125)", maxLength: 125, nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.orderID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    productID = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    unitID = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    productName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    price = table.Column<int>(type: "int", nullable: true),
                    productImageCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.productID);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    statusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    statusName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.statusID);
                });

            migrationBuilder.CreateTable(
                name: "TypeGifts",
                columns: table => new
                {
                    typeGiftID = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    typeGiftImageCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeGifts", x => x.typeGiftID);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    unitID = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    unitName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.unitID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "TypeGifts");

            migrationBuilder.DropTable(
                name: "Units");
        }
    }
}
