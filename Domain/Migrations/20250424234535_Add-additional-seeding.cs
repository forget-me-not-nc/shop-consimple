using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class Addadditionalseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "RegistrationDate" },
                values: new object[] { new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5827), new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "RegistrationDate" },
                values: new object[] { new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5831), new DateTime(2025, 4, 9, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "RegistrationDate" },
                values: new object[] { new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5836), new DateTime(2025, 3, 25, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "RegistrationDate" },
                values: new object[] { new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5837), new DateTime(2025, 3, 20, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5838) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "RegistrationDate" },
                values: new object[] { new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5838), new DateTime(2025, 3, 5, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5853));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClientId", "CreateDate", "Currency", "DeleteDate", "OrderNumber", "OrderValue", "UpdateDate" },
                values: new object[,]
                {
                    { 6, 1, new DateTime(2025, 3, 5, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5895), 1, null, "ORD-001", 89.98m, null },
                    { 7, 2, new DateTime(2025, 3, 15, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5896), 1, null, "ORD-002", 29.00m, null },
                    { 8, 3, new DateTime(2025, 3, 25, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5897), 1, null, "ORD-003", 303.70m, null },
                    { 9, 4, new DateTime(2025, 4, 4, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5898), 1, null, "ORD-004", 29.99m, null },
                    { 10, 5, new DateTime(2025, 4, 14, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5899), 1, null, "ORD-005", 39.98m, null }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 23, 45, 34, 583, DateTimeKind.Utc).AddTicks(5817));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "RegistrationDate" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8896), new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "RegistrationDate" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8899), new DateTime(2025, 4, 9, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "RegistrationDate" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8905), new DateTime(2025, 3, 25, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "RegistrationDate" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8906), new DateTime(2025, 3, 20, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "RegistrationDate" },
                values: new object[] { new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8907), new DateTime(2025, 3, 5, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 4, 24, 21, 27, 13, 182, DateTimeKind.Utc).AddTicks(8885));
        }
    }
}
