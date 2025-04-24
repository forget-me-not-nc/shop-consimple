using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDeclarationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrderValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => new { x.ProductId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreateDate", "DeleteDate", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Toys", new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8793), null, null },
                    { 2, "Electronics", new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8794), null, null },
                    { 3, "Books", new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8795), null, null },
                    { 4, "Clothing", new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8795), null, null }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "BirthDate", "CreateDate", "DeleteDate", "FirstName", "FullName", "LastName", "RegistrationDate", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8896), null, "John", "John Doe", "Doe", new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8899), null },
                    { 2, new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8899), null, "Jane", "Jane Smith", "Smith", new DateTime(2025, 4, 9, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8900), null },
                    { 3, new DateTime(1992, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8905), null, "Alice", "Alice Johnson", "Johnson", new DateTime(2025, 3, 25, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8906), null },
                    { 4, new DateTime(1988, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8906), null, "Bob", "Bob Williams", "Williams", new DateTime(2025, 3, 20, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8907), null },
                    { 5, new DateTime(1995, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8907), null, "Emma", "Emma Brown", "Brown", new DateTime(2025, 3, 5, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8908), null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClientId", "CreateDate", "Currency", "DeleteDate", "OrderNumber", "OrderValue", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8918), 1, null, "ORD-001", 89.98m, null },
                    { 2, 2, new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8922), 1, null, "ORD-002", 29.00m, null },
                    { 3, 3, new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8923), 1, null, "ORD-003", 303.70m, null },
                    { 4, 4, new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8924), 1, null, "ORD-004", 29.99m, null },
                    { 5, 5, new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8924), 1, null, "ORD-005", 39.98m, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateDate", "Currency", "DeleteDate", "Price", "ProductDeclarationName", "ProductTitle", "SKU", "UpdateDate" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8879), 1, null, 29.99m, "Ergonomic Wireless Mouse", "Wireless Mouse", "SKU-MOUSE-001", null },
                    { 2, 2, new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8882), 1, null, 59.99m, "Over-Ear Bluetooth Headphones", "Bluetooth Headphones", "SKU-HEAD-002", null },
                    { 3, 2, new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8883), 1, null, 14.50m, "Adjustable Smartphone Desk Stand", "Smartphone Stand", "SKU-STAND-003", null },
                    { 4, 1, new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8884), 1, null, 19.99m, "Creative Kids Building Blocks", "Building Blocks Set", "SKU-BLOCKS-004", null },
                    { 5, 1, new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8885), 1, null, 11.25m, "Wooden Animal Puzzle for Kids", "Educational Puzzle", "SKU-PUZZLE-005", null }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "OrderId", "ProductId", "Currency", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 29.99m },
                    { 3, 1, 1, 1, 29.99m },
                    { 4, 1, 1, 1, 29.99m },
                    { 1, 2, 1, 1, 59.99m },
                    { 3, 2, 1, 4, 59.99m },
                    { 2, 3, 1, 2, 14.50m },
                    { 5, 4, 1, 2, 19.99m },
                    { 3, 5, 1, 3, 11.25m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_OrderId",
                table: "OrderProducts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
